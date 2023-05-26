using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.ViewModels
{
    [QueryProperty(nameof(SelectedProduct), "product")]
    [QueryProperty(nameof(SelectedRestaurant), "restaurant")]


    public partial class ProductDetailsViewModel : BaseViewModel
    {
        readonly CartItemService cartItemService;

        [ObservableProperty]
        Product selectedProduct;

        [ObservableProperty]
        Restaurant selectedRestaurant;

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

        public ProductDetailsViewModel(CartItemService _cartItemService)
        {
            TotalQuantity = 0;
            cartItemService = _cartItemService;
        }

       

        [RelayCommand]
        private async Task GoToCart()
        {
            await Shell.Current.GoToAsync(nameof(CartView));
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
    }
}
