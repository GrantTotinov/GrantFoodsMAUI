namespace GrantFoods.Views;

public partial class OffersView : ContentPage
{
	public OffersView(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		BindingContext = homeViewModel;
	}
}