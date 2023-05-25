namespace GrantFoods.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }

        FirebaseClient client;

        public AddCategoryData()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
            Categories = new List<Category>()
            {
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Burgers",
                    CategoryImg = "burgercategory",
                    CategoryPoster = "burgerposter"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Pizza",
                    CategoryImg = "pizzacategory",
                    CategoryPoster = "pizzaposter"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Desserts",
                    CategoryImg = "dessertcategory",
                    CategoryPoster = "dessertposter"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Sushi",
                    CategoryImg = "sushicategory",
                    CategoryPoster = "sushiposter"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Mexican",
                    CategoryImg = "mexicancategory",
                    CategoryPoster = "mexicanposter"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Vegan",
                    CategoryImg = "vegancategory",
                    CategoryPoster = "veganposter"
                },
            };
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryId=category.CategoryId,
                        CategoryName=category.CategoryName,
                        CategoryImg=category.CategoryImg,
                        CategoryPoster=category.CategoryPoster
                    });
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error",ex.Message,"OK");
            }
        }
    }
}
