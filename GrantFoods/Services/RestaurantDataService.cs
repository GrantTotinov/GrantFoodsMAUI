using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.Services
{
    public class RestaurantDataService
    {
        FirebaseClient client;
        public RestaurantDataService()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            var restaurants = (await client.Child("Restaurants").OnceAsync<Restaurant>()).Select(r => new Restaurant
            {
                RestaurantId=r.Object.RestaurantId,
                CategoryId = r.Object.CategoryId,
                RestaurantName =r.Object.RestaurantName,
                RestaurantImg=r.Object.RestaurantImg,
                RestaurantDescription=r.Object.RestaurantDescription,
                RestaurrantRating=r.Object.RestaurrantRating,
                RestaurantLocation=r.Object.RestaurantLocation
                
            }).ToList();
            return restaurants;
        }

       

        public async Task<ObservableCollection<Restaurant>> GetRestaurantsByCategoriesAsync(int categoryId)
        {
            var restaurantsbycategories = new ObservableCollection<Restaurant>();
            var items = (await GetRestaurantsAsync()).Where(r => r.CategoryId == categoryId).ToList();
            foreach (var item in items)
            {
                restaurantsbycategories.Add(item);
            }
            return restaurantsbycategories;
        }
    }
}
