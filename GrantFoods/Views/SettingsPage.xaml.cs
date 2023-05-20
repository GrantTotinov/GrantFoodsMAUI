namespace GrantFoods.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    async void ButtonCategories_Clicked(object sender, EventArgs e)
    {
        var addcategorydata = new AddCategoryData();
        await addcategorydata.AddCategoriesAsync();
    }

    async void ButtonProducts_Clicked(object sender, EventArgs e)
    {
        var addproductsdata = new AddProductsData();
        await addproductsdata.AddProductsAsync();
    }

    private void ButtonCart_Clicked(object sender, EventArgs e)
    {

    }

    async void ButtonRestaurants_Clicked(object sender, EventArgs e)
    {
        var addrestaurantsdata = new AddRestaurantsData();
        await addrestaurantsdata.AddRestaurantsAsync();
    }
}