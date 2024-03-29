﻿//System Usings
global using Microsoft.Extensions.Logging;
global using System.Collections.ObjectModel;
#if ANDROID
global using Android.Graphics.Drawables;
global using Android.Content;
#endif
global using Microsoft.Maui.Controls.Platform;
global using Timer = System.Timers.Timer;
global using System.Linq;
  


//Nuget Usings
global using SkiaSharp.Views.Maui.Controls.Hosting;
global using CommunityToolkit.Maui;
global using CommunityToolkit.Mvvm.Input;
global using CommunityToolkit.Mvvm.ComponentModel;
global using Firebase.Database;
global using Firebase.Database.Query;
global using SQLite;



//MVVM Usings
global using GrantFoods.Services;
global using GrantFoods.ViewModels;
global using GrantFoods.Views;
global using GrantFoods.Models;
global using GrantFoods.Helpers;

namespace GrantFoods;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                fonts.AddFont("Teko-Bold.ttf", "TekoBold");
                fonts.AddFont("Teko-Light.ttf", "TekoLight");
                fonts.AddFont("Teko-Medium.ttf", "TekoMedium");
                fonts.AddFont("Teko-Regular.ttf", "TekoRegular");
                fonts.AddFont("Teko-SemiBold.ttf", "TekoSemiBold");

                fonts.AddFont("Nexa-ExtraLight.ttf", "NexaLight");
                fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");

                fonts.AddFont("BebasNeue-Regular.ttf", "Bebas");
                fonts.AddFont("Roboto-Medium.ttf", "Roboto");


            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        //Services Region
		builder.Services.AddSingleton<LandingPageService>();
        builder.Services.AddSingleton<CartItemService>();
        builder.Services.AddSingleton<CategoryDataService>();
        builder.Services.AddSingleton<ProductDataService>();
        builder.Services.AddSingleton<UserService>();
        builder.Services.AddSingleton<RestaurantDataService>();
        builder.Services.AddSingleton<DatabaseService>();

        //ViewModels Region
        builder.Services.AddTransient<LandingViewModel>();
        builder.Services.AddTransient<UserViewModel>();
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<CategoryViewModel>();
        builder.Services.AddTransient<ProductDetailsViewModel>();
        builder.Services.AddTransient<CartViewModel>();
        builder.Services.AddTransient<RestaurantDetailsViewModel>();
        builder.Services.AddTransient<LogoutViewModel>();




        //Views Region
        builder.Services.AddTransient<LoginView>();
        builder.Services.AddTransient<RegisterView>();
        builder.Services.AddTransient<HomeView>();
        builder.Services.AddTransient<OffersView>();
        builder.Services.AddTransient<CartView>();
        builder.Services.AddTransient<AccountView>();
        builder.Services.AddTransient<LandingView>();
        builder.Services.AddTransient<CategoryView>();
        builder.Services.AddTransient<ProductView>();
        builder.Services.AddTransient<RestaurantView>();
        builder.Services.AddTransient<OrderView>();
        builder.Services.AddTransient<LogoutView>();



        return builder.Build();
	}
}
