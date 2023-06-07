namespace GrantFoods.Views;

public partial class LogoutView : ContentPage
{
	LogoutViewModel logoutViewModel;
	public LogoutView(LogoutViewModel _logoutViewModel)
	{
		InitializeComponent();
		logoutViewModel = _logoutViewModel;
		BindingContext = logoutViewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _ = logoutViewModel.IsCartExistingMethod();
    }
}