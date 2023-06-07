using System.Runtime.CompilerServices;

namespace GrantFoods.Views;

public partial class RegisterView : ContentPage
{
	UserViewModel userViewModel;
	public RegisterView(UserViewModel _userViewModel)
	{
		InitializeComponent();
		userViewModel = _userViewModel;
		BindingContext = userViewModel;
	}

    
    
}