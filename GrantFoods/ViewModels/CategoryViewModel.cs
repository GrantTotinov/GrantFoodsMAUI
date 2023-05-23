namespace GrantFoods.ViewModels
{
    [QueryProperty(nameof(SelectedCategory), "category")]
    


    public partial class CategoryViewModel: BaseViewModel
    {
        [ObservableProperty]
        Category selectedCategory;

       

        [ObservableProperty]
        int totalProducts;


        readonly ProductDataService productDataService;
        
        public ObservableCollection<Product> ProductsByCategory { get; set; } = new();
        public async void GetProducts(int categoryid)
        {
            var data = await productDataService.GetProductsByCategoriesAsync(categoryid);
            ProductsByCategory.Clear();
            foreach (var product in data)
            {
                ProductsByCategory.Add(product);
            }

        }

        public CategoryViewModel(ProductDataService _productDataService)
        {
            productDataService = _productDataService;
            if (SelectedCategory != null)
            {
                
                GetProducts(SelectedCategory.CategoryId);
            }
            else Shell.Current.DisplayAlert("Error", "ok", "cancel");
        }

        
        
    }

}
