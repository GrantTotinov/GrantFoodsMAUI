

namespace GrantFoods.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        readonly CartItemService cartItemService;
        readonly CategoryDataService categoryDataService;
        readonly ProductDataService productDataService;
        readonly RestaurantDataService restaurantDataService;

        [ObservableProperty]
        string userName;

        [ObservableProperty]
        int userCartItemCount;


        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> TopRatedItems { get; set; }
        public ObservableCollection<Restaurant> TopRatedRestaurants { get; set; }
        public ObservableCollection<Product> Offers { get; set; }

        public HomeViewModel(CartItemService _cartItemService, CategoryDataService _categoryDataService, ProductDataService _productDataService, RestaurantDataService _restaurantDataService)
        {
            cartItemService = _cartItemService;
            categoryDataService = _categoryDataService;
            productDataService = _productDataService;
            restaurantDataService = _restaurantDataService;

            var username = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(username))
                UserName = "Guest";
            else
                UserName = username;

            
            UserCartItemCount = cartItemService.GetUserCartCount();

            Categories = new ObservableCollection<Category>();
            TopRatedItems = new ObservableCollection<Product>();
            TopRatedRestaurants = new ObservableCollection<Restaurant>();
            Offers = new ObservableCollection<Product>();

            GetCategories();
            GetTopRatedItems();
            GetTopRatedRestaurants();
            GetOffers();
        }

        private async void GetOffers()
        {
            var data = await productDataService.GetProductsbyPriceDec();
            Offers.Clear();
            foreach(var product in data)
            {
                Offers.Add(product);
            }
        }

        [RelayCommand]
        private async Task ViewCartAsync()
        {
            await Shell.Current.GoToAsync($"//{nameof(CartView)}");
        }



        private async void GetCategories()
        {
            var data = await categoryDataService.GetCategoriesAsync();
            Categories.Clear();
            foreach (var category in data)
            {
                Categories.Add(category);
            }
        }

        private async void GetTopRatedItems()
        {
            var data = await productDataService.GetProductsAsync();
            TopRatedItems.Clear();
            foreach(var product in data)
            {
                TopRatedItems.Add(product);
            }
        }

        private async void GetTopRatedRestaurants()
        {
            var data = await restaurantDataService.GetRestaurantsAsync();
            TopRatedRestaurants.Clear();
            foreach(var restaurant in data)
            {
                TopRatedRestaurants.Add(restaurant);
            }
        }

        //testova komanda za vlizane v categorii
        [RelayCommand]
        async Task GotoCategory(Category category)
        {
            if (category == null)
                return;
            await Shell.Current.GoToAsync(nameof(CategoryView), true, new Dictionary<string, object>
        {
            {"category", category }
        });
        }
    }
}
