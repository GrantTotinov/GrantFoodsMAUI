namespace GrantFoods.Views;

public partial class CartView : ContentPage
{
	CartViewModel cartViewModel;
	public CartView(CartViewModel _cartViewModel)
	{
		InitializeComponent();
		cartViewModel = _cartViewModel;
		BindingContext = cartViewModel;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		//await cartViewModel.LoadCartItemsAsync();
    }
}