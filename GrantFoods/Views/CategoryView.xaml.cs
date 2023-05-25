namespace GrantFoods.Views;

public partial class CategoryView : ContentPage
{
    CategoryViewModel categoryViewModel;

    public CategoryView(CategoryViewModel _categoryViewModel)
	{
        categoryViewModel = _categoryViewModel;
		InitializeComponent();
        
        BindingContext = _categoryViewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var categoryid = categoryViewModel.SelectedCategory.CategoryId;
        categoryViewModel.GetProducts(categoryid);
        categoryViewModel.GetRestaurants(categoryid);
    }

    
}