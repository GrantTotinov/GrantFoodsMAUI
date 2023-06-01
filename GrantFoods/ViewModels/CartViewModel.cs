using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.ViewModels
{
    public partial class CartViewModel : BaseViewModel
    {
        private readonly DatabaseService databaseService;

        [ObservableProperty]
        public ObservableCollection<UserCartItem> cartItems; 

        [ObservableProperty]
        decimal totalCost;

        public CartViewModel(DatabaseService _databaseService)
        {
            databaseService = _databaseService;
            TotalCost = 0;
            LoadCartItemsAsync();    
            
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
        
    }
}
