namespace GrantFoods.Views;

public partial class RestaurantView : ContentPage
{
	public RestaurantView(RestaurantDetailsViewModel restaurantDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = restaurantDetailsViewModel;
	}
}