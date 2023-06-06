using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.ViewModels
{
    public partial class RestaurantDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly ProductDataService productDataService;

        public ObservableCollection<Product> ProductsByRestaurant { get; set; } = new();

        [ObservableProperty]
        Restaurant selectedRestaurant;

        public RestaurantDetailsViewModel(ProductDataService _productDataService)
        {
            productDataService = _productDataService;
            if(SelectedRestaurant != null)
            {
                GetPRoductsByRestaurantsASync(SelectedRestaurant.RestaurantId);
            }
        }

        public async void GetPRoductsByRestaurantsASync(int restaurantId)
        {
            var data = await productDataService.GetProductsByRestaurantsAsync(restaurantId);
            ProductsByRestaurant.Clear();
            foreach (var product in data)
            {
                ProductsByRestaurant.Add(product);
            }
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            SelectedRestaurant = query["restaurant"] as Restaurant;
            GetPRoductsByRestaurantsASync(SelectedRestaurant.RestaurantId);
        }
        [RelayCommand]
        public async Task GoToProductsFromRestaurantAsync(Product product)
        {
        {
            if (product == null)
            return;
            await Shell.Current.GoToAsync(nameof(ProductView), true, new Dictionary<string, object>
        {
            {"product", product }
        });
        }
        }
        [RelayCommand]
        private async Task ReturnHomeFromRestaurantsAsync()
        {
            await Shell.Current.GoToAsync(nameof(HomeView), true);
        }
    }
}
