
namespace GrantFoods;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(LandingView), typeof(LandingView));
        Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
        Routing.RegisterRoute(nameof(RegisterView), typeof(RegisterView));
        Routing.RegisterRoute(nameof(LogoutView), typeof(LogoutView));

        Routing.RegisterRoute(nameof(OffersView), typeof(OffersView));
        Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
        Routing.RegisterRoute(nameof(CartView), typeof(CartView));
        Routing.RegisterRoute(nameof(AccountView), typeof(AccountView));
        Routing.RegisterRoute(nameof(OrderView), typeof(OrderView));

        Routing.RegisterRoute(nameof(CategoryView), typeof(CategoryView));
        Routing.RegisterRoute(nameof(ProductView), typeof(ProductView));
        Routing.RegisterRoute(nameof(RestaurantView), typeof(RestaurantView));


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

    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);
        if (args.Source == ShellNavigationSource.ShellSectionChanged)
        {
            var navigation = Shell.Current.Navigation;
            var pages = navigation.NavigationStack;
            for (var i = pages.Count - 1; i >= 1; i--)
            {
                navigation.RemovePage(pages[i]);
            }
        }
    }



}
