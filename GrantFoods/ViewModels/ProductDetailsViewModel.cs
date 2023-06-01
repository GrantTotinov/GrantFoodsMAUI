using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.ViewModels
{
    //[QueryProperty(nameof(SelectedProduct), "productfromcategory")]
    

    public partial class ProductDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        readonly CartItemService cartItemService;
        readonly DatabaseService databaseService;

        [ObservableProperty]
        Product selectedProduct;

        private int _TotalQuantity;
        public int TotalQuantity
        {
            set { 
                    _TotalQuantity = value; 
                    if (_TotalQuantity < 0)
                        _TotalQuantity = 0;
                    if(_TotalQuantity > 10)
                        _TotalQuantity -=1;
                    OnPropertyChanged();
                }
            get { return _TotalQuantity; }
        }

        public ProductDetailsViewModel(CartItemService _cartItemService, DatabaseService _databaseService)
        {
            TotalQuantity = 0;
            cartItemService = _cartItemService;
            databaseService = _databaseService;
        }

        [RelayCommand]
        private async Task AddToCart()
        {
            if (TotalQuantity > 0)
            {
                try {
                    CartItem cartItem = new CartItem()
                    {
                        ProductId = SelectedProduct.ProductId,
                        ProductName = SelectedProduct.ProductName,
                        ProductImg = SelectedProduct.ProductImg,
                        ProductPrice = SelectedProduct.ProductPrice,
                        Quantity = TotalQuantity
                    };
                    await databaseService.AddItemAsync<CartItem>(cartItem);
                    await Shell.Current.DisplayAlert("BonApetit", "Selected product is added to the cart", "OK");
                    //}
                }
                catch (Exception ex)
                {
                    await Shell.Current.DisplayAlert("Oops", ex.Message, "OK");
                }
                finally
                {
                    await Shell.Current.GoToAsync(nameof(CartView));
                }
            }
            else
            {
                await Shell.Current.DisplayAlert("Oops", "You need to choose at least one item", "OK");
            }

            


        }

        [RelayCommand]
        public async Task GoToCartFromProduct(CartItem cartItem)
        {
            await Shell.Current.GoToAsync(nameof(CartView), true, new Dictionary<string, object>
        {
            {"cartitem", cartItem }
        });
        }

        

        [RelayCommand]
        private void IcrementOrder()
        {
            TotalQuantity++;
        }

        [RelayCommand]
        private void DecrementOrder()
        {
            TotalQuantity--;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            SelectedProduct = query["productfromcategory"] as Product;
        }
    }
}
