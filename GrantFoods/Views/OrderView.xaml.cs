namespace GrantFoods.Views;

public partial class OrderView : ContentPage
{
    CartViewModel cartViewModel;
	public OrderView(CartViewModel _cartViewModel)
	{
		InitializeComponent();
        cartViewModel = _cartViewModel;
		BindingContext = cartViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        cartViewModel.OrderIdProperty.ToString();
        cartViewModel.UserName.ToString();
    }
}