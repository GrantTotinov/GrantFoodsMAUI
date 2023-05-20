namespace GrantFoods.Views;

public partial class RegisterView : ContentPage
{
	public RegisterView(UserViewModel userViewModel)
	{
		InitializeComponent();
		BindingContext = userViewModel;
	}
}