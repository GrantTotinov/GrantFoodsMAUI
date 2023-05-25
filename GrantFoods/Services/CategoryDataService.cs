
namespace GrantFoods.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories").OnceAsync<Category>()).Select(c => new Category
            {
                CategoryId = c.Object.CategoryId,
                CategoryName = c.Object.CategoryName,
                CategoryImg =c.Object.CategoryImg,
                CategoryPoster = c.Object.CategoryPoster,
            }).ToList();
            return categories;
        }
    }
}
