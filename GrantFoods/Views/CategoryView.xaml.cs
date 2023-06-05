namespace GrantFoods.Views;

public partial class CategoryView : ContentPage
{
    public CategoryView(CategoryViewModel _categoryViewModel)
	{
		InitializeComponent();
        BindingContext = _categoryViewModel;
    }

   

    
}