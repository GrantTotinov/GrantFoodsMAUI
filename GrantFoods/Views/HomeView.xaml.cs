
using System.Collections;

namespace GrantFoods.Views;

public partial class HomeView : ContentPage
{
    HomeViewModel homeViewModel;
   
    public HomeView(HomeViewModel _homeViewModel)
	{
		InitializeComponent();
        homeViewModel = _homeViewModel;
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

    protected override  void OnAppearing()
    {
        base.OnAppearing();
        _ = homeViewModel.ReturnCount();
    }



}