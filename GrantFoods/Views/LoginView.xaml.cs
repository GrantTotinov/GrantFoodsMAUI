namespace GrantFoods.Views;

public partial class LoginView : ContentPage
{
	public LoginView(UserViewModel userViewModel)
	{
		InitializeComponent();
		BindingContext = userViewModel;
	}
}