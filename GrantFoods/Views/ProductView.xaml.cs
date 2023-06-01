namespace GrantFoods.Views;

public partial class ProductView : ContentPage
{
	
	public ProductView(ProductDetailsViewModel productDetailsViewModel)
	{
		
		InitializeComponent();
		BindingContext = productDetailsViewModel;
	}

    
}