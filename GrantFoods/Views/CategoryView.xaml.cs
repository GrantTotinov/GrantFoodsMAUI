namespace GrantFoods.Views;

public partial class CategoryView : ContentPage
{
    CategoryViewModel categoryViewModel;
    
    public CategoryView(CategoryViewModel categoryViewModel)
	{
		InitializeComponent();
        
        BindingContext = categoryViewModel;
    }
}