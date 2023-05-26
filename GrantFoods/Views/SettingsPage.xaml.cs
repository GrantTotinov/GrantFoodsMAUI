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
        /*var createcarttable = new CreateCartTable();
        if(createcarttable.CreateTable())
            DisplayAlert("Success", "Cart Table Created", "OK");
        else
            DisplayAlert("ERROR", "Error while creating table", "OK");*/
    }

    async void ButtonRestaurants_Clicked(object sender, EventArgs e)
    {
        var addrestaurantsdata = new AddRestaurantsData();
        await addrestaurantsdata.AddRestaurantsAsync();
    }
}