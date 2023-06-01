namespace GrantFoods.ViewModels
{
   // [QueryProperty(nameof(SelectedCategory), "category")]
    


    public partial class CategoryViewModel: BaseViewModel, IQueryAttributable
    {
        [ObservableProperty]
        Category selectedCategory = new();


        readonly ProductDataService productDataService;
        readonly RestaurantDataService restaurantDataService;
        
        public ObservableCollection<Product> ProductsByCategory { get; set; } = new();
        public ObservableCollection<Restaurant> RestaurantsByCategory { get; set; } = new();
        

        public CategoryViewModel(ProductDataService _productDataService, RestaurantDataService _restaurantDataService)
        {
            
            productDataService = _productDataService;
            restaurantDataService = _restaurantDataService;

            if (SelectedCategory != null)
            {
                GetProducts(SelectedCategory.CategoryId);
                GetRestaurants(SelectedCategory.CategoryId);
            }
            
        }

        public async void GetRestaurants(int categoryId)
        {
            var data = await restaurantDataService.GetRestaurantsByCategoriesAsync(categoryId);
            RestaurantsByCategory.Clear();
            foreach (var restaurant in data)
            {
                RestaurantsByCategory.Add(restaurant);
            }
        }

        public async void GetProducts(int categoryid)
        {
            var data = await productDataService.GetProductsByCategoriesAsync(categoryid);
            ProductsByCategory.Clear();
            foreach (var product in data)
            {
                ProductsByCategory.Add(product);
            }

        }

        [RelayCommand]
        async Task GoToProductFromCategory(Product productfromcategory)
        {
            if (productfromcategory == null)
                return;
            await Shell.Current.GoToAsync(nameof(ProductView), true, new Dictionary<string, object>
        {
            {"productfromcategory", productfromcategory }
        });
        }
        [RelayCommand]
        async Task GoToRestaurantFromCategory(Restaurant restaurantfromcategory)
        {
            if (restaurantfromcategory == null)
                return;
            await Shell.Current.GoToAsync(nameof(RestaurantView), true, new Dictionary<string, object>
        {
            {"restaurantfromcategory", restaurantfromcategory }
        });
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            SelectedCategory = query["category"] as Category;
            GetRestaurants(SelectedCategory.CategoryId);
            GetProducts(SelectedCategory.CategoryId);
        }
    }
}
