

namespace GrantFoods.Views;

public partial class OffersView : ContentPage
{
	HomeViewModel homeViewModel;
	public OffersView(HomeViewModel _homeViewModel)
	{
		InitializeComponent();
		homeViewModel = _homeViewModel;
		BindingContext = _homeViewModel;
	}

    public void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
		if (string.IsNullOrWhiteSpace(e.NewTextValue))
			OffersCollectionView.ItemsSource = homeViewModel.Offers;
		else
			OffersCollectionView.ItemsSource = homeViewModel.Offers.Where(i => i.ProductName.ToLower().Contains(e.NewTextValue.ToLower()));
    }
}