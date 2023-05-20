namespace GrantFoods;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LandingView), typeof(LandingView));
        Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
        Routing.RegisterRoute(nameof(RegisterView), typeof(RegisterView));

        Routing.RegisterRoute(nameof(OffersView), typeof(OffersView));
        Routing.RegisterRoute(nameof(FavouritesView), typeof(FavouritesView));
        Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
        Routing.RegisterRoute(nameof(CartView), typeof(CartView));
        Routing.RegisterRoute(nameof(AccountView), typeof(AccountView));



        string username = Preferences.Get("Username", String.Empty);
        if (String.IsNullOrEmpty(username))
        {
           MyAppShell.CurrentItem = MyLandingPage;
        }
        else
        {
            MyAppShell.CurrentItem = MyHomePage;
        }
    }
}
