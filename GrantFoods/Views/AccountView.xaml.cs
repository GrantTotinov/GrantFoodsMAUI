namespace GrantFoods.Views;

public partial class AccountView : ContentPage
{
	public AccountView(LogoutViewModel logoutViewModel)
	{
		InitializeComponent();
		BindingContext = logoutViewModel;
	}
}