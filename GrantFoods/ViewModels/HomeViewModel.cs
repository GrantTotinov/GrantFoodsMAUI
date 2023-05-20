namespace GrantFoods.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        CartItemService cartItemService;
        CategoryDataService categoryDataService;
        ProductDataService productDataService;

        [ObservableProperty]
        string userName;

        [ObservableProperty]
        int userCartItemCount;

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> TopRatedItems { get; set; }
        public ObservableCollection<Restaurant> TopRatedRestaurants { get; set; }
        public ObservableCollection<Product> Offers { get; set; }

        public HomeViewModel(CartItemService _cartItemService, CategoryDataService _categoryDataService, ProductDataService _productDataService)
        {
            cartItemService = _cartItemService;
            categoryDataService = _categoryDataService;
            productDataService = _productDataService;

            var username = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(username))
                UserName = "Guest";
            else
                UserName = username;

            UserCartItemCount = new CartItemService().GetUserCartCount();
            
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
            var data = await new ProductDataService().GetProductsbyPriceDec();
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
            var data = await new CategoryDataService().GetCategoriesAsync();
            Categories.Clear();
            foreach (var category in data)
            {
                Categories.Add(category);
            }
        }

        private async void GetTopRatedItems()
        {
            var data = await new ProductDataService().GetProductsAsync();
            TopRatedItems.Clear();
            foreach(var product in data)
            {
                TopRatedItems.Add(product);
            }
        }

        private async void GetTopRatedRestaurants()
        {
            var data = await new RestaurantDataService().GetRestaurantsAsync();
            TopRatedRestaurants.Clear();
            foreach(var restaurant in data)
            {
                TopRatedRestaurants.Add(restaurant);
            }
        }
    }
}
