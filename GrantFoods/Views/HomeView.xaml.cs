
namespace GrantFoods.Views;

public partial class HomeView : ContentPage
{

	public HomeView(HomeViewModel homeViewModel)
	{
		InitializeComponent();
        BindingContext = homeViewModel;
        Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {

            if (view is Picker)
            {
#if ANDROID
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                // handler.PlatformView.SetBackgroundDrawable(gd); deprecated  
                handler.PlatformView.SetBackground(gd);
#endif
            }
        });

        AnimateCarousel();
    }

    Timer timer;

    [Obsolete]
    private void AnimateCarousel()
    {
        timer = new Timer(4000) { AutoReset = true, Enabled = true};
        timer.Elapsed += (s, e) =>
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if(cvRestaurants.Position == 7)
                {
                    cvRestaurants.Position = 0;
                    return;
                }
                cvRestaurants.Position += 1;
            });
        };
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    private async void Products_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var category = e.CurrentSelection.FirstOrDefault() as Category;
        if (category == null)
            return;
        //await Shell.Current.GoToAsync(new CategoryView(category));
    }

    private void Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}