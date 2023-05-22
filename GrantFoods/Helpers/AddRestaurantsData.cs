
namespace GrantFoods.Helpers
{
    public class AddRestaurantsData
    {
        FirebaseClient client;
        public List<Restaurant> Restaurants { get; set; }
        public AddRestaurantsData()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
            Restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    RestaurantId = 1,
                    CategoryId = 1,
                    RestaurantName = "McDonald's",
                    RestaurantImg = "mcdonaldslogo",
                    RestaurrantRating = 4.2m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    CategoryId = 1,
                    RestaurantName = "BurgerKing",
                    RestaurantImg = "burgerkinglogo",
                    RestaurrantRating = 4.1m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 3,
                    CategoryId = 2,
                    RestaurantName = "Verdi",
                    RestaurantImg = "verdilogo",
                    RestaurrantRating = 4.4m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 4,
                    CategoryId = 2,
                    RestaurantName = "PizzaHub",
                    RestaurantImg = "pizzahublogo",
                    RestaurrantRating = 3.9m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 5,
                    CategoryId = 3,
                    RestaurantName = "Nikko",
                    RestaurantImg = "nikkologo",
                    RestaurrantRating = 4.6m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 6,
                    CategoryId = 3,
                    RestaurantName = "Sunday",
                    RestaurantImg = "sundaylogo",
                    RestaurrantRating = 4.2m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 7,
                    CategoryId = 4,
                    RestaurantName = "Toro Grande",
                    RestaurantImg = "torograndelogo",
                    RestaurrantRating = 4.4m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 8,
                    CategoryId = 4,
                    RestaurantName = "Happy Grill & Bar",
                    RestaurantImg = "happylogo",
                    RestaurrantRating = 4m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 9,
                    CategoryId = 5,
                    RestaurantName = "Sombrero",
                    RestaurantImg = "sombrerologo",
                    RestaurrantRating = 4.1m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
                new Restaurant
                {
                    RestaurantId = 10,
                    CategoryId = 5,
                    RestaurantName = "Tacobell",
                    RestaurantImg = "tacobelllogo",
                    RestaurrantRating = 3.9m,
                    RestaurantDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    RestaurantLocation = ""
                },
            };
        }
        public async Task AddRestaurantsAsync()
        {
            try
            {
                foreach (var restaurant in Restaurants)
                {
                    await client.Child("Restaurants").PostAsync(new Restaurant()
                    {
                        RestaurantId=restaurant.RestaurantId,
                        CategoryId=restaurant.CategoryId,
                        RestaurantName=restaurant.RestaurantName,
                        RestaurantImg=restaurant.RestaurantImg,
                        RestaurrantRating=restaurant.RestaurrantRating,
                        RestaurantDescription=restaurant.RestaurantDescription,
                        RestaurantLocation=restaurant.RestaurantLocation
                    });
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
