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
        public ObservableCollection<Product> ProductsByCategory { get; set; }

        public CategoryViewModel(ProductDataService _productDataService)
        {
            productDataService = _productDataService;
        }
        public CategoryViewModel(Category category)
        {
            category = SelectedCategory;
            GetProducts(category.CategoryId);
            ProductsByCategory = new ObservableCollection<Product>();
        }
        

        private async void GetProducts(int categoryId)
        {
            var data = await productDataService.GetProductsByCategoriesAsync(categoryId);
            ProductsByCategory.Clear();
            foreach(var item in data)
            {
                ProductsByCategory.Add(item);
            }
            TotalProducts=ProductsByCategory.Count;
        }
    }

}
