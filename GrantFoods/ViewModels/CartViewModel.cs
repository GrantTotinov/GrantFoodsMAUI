using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrantFoods.ViewModels
{
    [QueryProperty(nameof(OrderIdProperty),nameof(OrderIdProperty))]
    [QueryProperty(nameof(UserName), nameof(UserName))]

    public partial class CartViewModel : BaseViewModel 
    {
        private readonly DatabaseService databaseService;
        private readonly FirebaseClient client;
        [ObservableProperty]
        public ObservableCollection<UserCartItem> cartItems; 

        [ObservableProperty]
        decimal totalCost;

        [ObservableProperty]
        string orderIdProperty;

        [ObservableProperty]
        string userName;
        
        public CartViewModel(DatabaseService _databaseService)
        {
           
            databaseService = _databaseService;
            TotalCost = 0;
            client = new FirebaseClient("https://grantfoods6-default-rtdb.europe-west1.firebasedatabase.app/");
            _ = LoadCartItemsAsync();
            
        }

        public async Task<string> PlaceOrderServiceAsync()
        {
            var cartitems = await databaseService.GetAllAsync<CartItem>();
            var orderId=Guid.NewGuid().ToString();

            var username = Preferences.Get("Username", "Guest");
            UserName = username;
            decimal totalCost = 0;

            foreach (var item in cartitems)
            {
                OrderDetails od = new OrderDetails()
                {
                    OrderId = orderId,
                    OrderDetailId = Guid.NewGuid().ToString(),
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.ProductPrice,
                    Quantity = item.Quantity
                };
                totalCost += item.ProductPrice * item.Quantity;
                await client.Child("OrderDetails").PostAsync(od);
            }
            await client.Child("Orders").PostAsync(
                new Order()
                {
                    OrderId = orderId,
                    UserName = username,
                    TotalCost = totalCost
                });
            return orderId;
        }
        [RelayCommand]
        private async Task PlaceOrderAsync()
        {
            if (CartItems == null)
            {
                await Shell.Current.DisplayAlert("Oops", "You need to chose food first", "OK");
            }
            else
            {
                var cartitems = await databaseService.GetAllAsync<CartItem>();
                OrderIdProperty = await PlaceOrderServiceAsync();
                
                IsBusy = true;
                try
                {
                    foreach(var item in cartitems)
                    {
                        await databaseService.DeleteItemAsync(item);
                    }
                    await Shell.Current.GoToAsync($"{nameof(OrderView)}?OrderIdProperty={OrderIdProperty}&UserName={UserName}", true);
                    

                }
                finally
                {
                    
                    IsBusy = false;

                }
                
            }
           
        }

        public async Task LoadCartItemsAsync()
        {
            var cartitems = await databaseService.GetAllAsync<CartItem>();
            if (cartitems is not null && cartitems.Any())
            {
                CartItems ??= new ObservableCollection<UserCartItem>();
                CartItems.Clear();

                foreach(var cartitem in cartitems)
                {
                     CartItems.Add(new UserCartItem()
                    {
                        CartItemId = cartitem.CartItemId,
                        ProductId=cartitem.ProductId,
                        ProductName=cartitem.ProductName,
                        ProductPrice=cartitem.ProductPrice,
                        ProductImg=cartitem.ProductImg,
                        Quantity=cartitem.Quantity,
                        Cost=cartitem.ProductPrice * cartitem.Quantity
                    });
                    TotalCost += cartitem.ProductPrice * cartitem.Quantity;

                }
            }
        }

        [RelayCommand]
         private async Task DeleteCartItemAsync(int Id)
        {
            IsBusy = true;
            try
            {
                if (await databaseService.DeleteItemByKeyAsync<CartItem>(Id))
                {
                    var cartitem = CartItems.FirstOrDefault(c => c.CartItemId == Id);
                    CartItems.Remove(cartitem);
                    
                }
                else
                {
                    await Shell.Current.DisplayAlert("Oops", "Something went wrong", "OK");
                }
            }
            finally
            {
                IsBusy = false;

            }
        }
        [RelayCommand]
        private async Task ReturnToHomeFromCartAsync()
        {
            await Shell.Current.GoToAsync(nameof(HomeView), true);
        }

        
    }
}
