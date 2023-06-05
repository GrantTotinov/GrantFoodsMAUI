

namespace GrantFoods.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        private readonly CartItemService cartItemService;
        private readonly CategoryDataService categoryDataService;
        private readonly ProductDataService productDataService;
        private readonly RestaurantDataService restaurantDataService;
        private readonly DatabaseService databaseService;


        [ObservableProperty]
        string userName;

        [ObservableProperty]
        int userCartItemCount;


        public ObservableCollection<Category> Categories { get; set; } = new();
        public ObservableCollection<Product> TopRatedItems { get; set; } = new();
        public ObservableCollection<Restaurant> TopRatedRestaurants { get; set; } = new();
        public ObservableCollection<Product> Offers { get; set; } = new();

        public HomeViewModel(CartItemService _cartItemService, CategoryDataService _categoryDataService, ProductDataService _productDataService, RestaurantDataService _restaurantDataService, DatabaseService _databaseService)
        {
            cartItemService = _cartItemService;
            categoryDataService = _categoryDataService;
            productDataService = _productDataService;
            restaurantDataService = _restaurantDataService;
            databaseService = _databaseService;

            var username = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(username))
                UserName = "Guest";
            else
                UserName = username;

            GetCategories();
            GetTopRatedItems();
            GetTopRatedRestaurants();
            GetOffers();
            //ReturnCount();
            
            

        }

        public async Task<int> ReturnCount()
        {
            var task = databaseService.GetTableCount<CartItem>();
            UserCartItemCount = await task;
            return UserCartItemCount;
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
            await Shell.Current.GoToAsync(nameof(CartView));
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
            var data = await productDataService.GetTopRatedProductsAsync();
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

        
        [RelayCommand]
        async Task GotoCategoryFromHome(Category category)
        {
            if (category == null)
                return;
            await Shell.Current.GoToAsync(nameof(CategoryView), true, new Dictionary<string, object>
        {
            {"category", category }
                
        });
        }
        [RelayCommand]
        async Task GoToProductFromHome(Product product)
        {
            if (product == null)
                return;
            await Shell.Current.GoToAsync(nameof(ProductView), true, new Dictionary<string, object>
        {
            {"product", product }
        });
        }

        [RelayCommand]
        async Task GoToRestaurantFromHome(Restaurant restaurant)
        {
            if (restaurant == null)
                return;
            await Shell.Current.GoToAsync(nameof(RestaurantView), true, new Dictionary<string, object>
        {
            {"restaurant", restaurant }
        });
        }
    }
}
