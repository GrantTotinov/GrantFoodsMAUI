
namespace GrantFoods.Helpers
{
    public class AddProductsData
    {
        FirebaseClient client;
        public List<Product> Products { get; set; }
        public AddProductsData()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
            Products = new List<Product>()
            {
                //
                //BURGERS--------------------------------------------------------
                //
                new Product
                {
                    ProductId = 1,
                    CategoryId = 1,
                    RestaurantId=1,
                    ProductName = "Big Mac",
                    ProductImg = "bigmac",
                    ProductPrice = 4.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.5m
                },
                new Product
                {
                    ProductId = 2,
                    CategoryId = 1,
                    RestaurantId=1,
                    ProductName = "Beef Deluxe",
                    ProductImg = "beefdeluxe",
                    ProductPrice = 5.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.2m
                },
                new Product
                {
                    ProductId = 3,
                    CategoryId = 1,
                    RestaurantId=1,
                    ProductName = "Big Rioshti",
                    ProductImg = "bigrioshti",
                    ProductPrice = 8.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.0m
                },
                new Product
                {
                    ProductId = 4,
                    CategoryId = 1,
                    RestaurantId=1,
                    ProductName = "Chicken Deluxe",
                    ProductImg = "chickendeluxe",
                    ProductPrice = 10.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.9m
                },
                new Product
                {
                    ProductId = 5,
                    CategoryId = 1,
                    RestaurantId=2,
                    ProductName = "Chicken Rioshti",
                    ProductImg = "chickenrioshti",
                    ProductPrice = 9.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.1m
                },
                new Product
                {
                    ProductId = 6,
                    CategoryId = 1,
                    RestaurantId=2,
                    ProductName = "Fish Rioshti",
                    ProductImg = "fishrioshti",
                    ProductPrice = 9.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=3.6m
                },
                new Product
                {
                    ProductId = 7,
                    CategoryId = 1,
                    RestaurantId=2,
                    ProductName = "McVeggie",
                    ProductImg = "mcveggie",
                    ProductPrice = 12.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=3.1m
                },
                //
                //PIZZA-----------------------------------------------------------------
                //
                new Product
                {
                    ProductId = 8,
                    CategoryId = 2,
                    RestaurantId=3,
                    ProductName = "Pepperonata",
                    ProductImg = "pepperonata",
                    ProductPrice = 15.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=4.9m
                },
                new Product
                {
                    ProductId = 9,
                    CategoryId = 2,
                    RestaurantId=3,
                    ProductName = "Big Joe",
                    ProductImg = "bigjoe",
                    ProductPrice = 19.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=4.4m
                },
                new Product
                {
                    ProductId = 10,
                    CategoryId = 2,
                    RestaurantId=3,
                    ProductName = "Garliccambero",
                    ProductImg = "garliccambero",
                    ProductPrice = 11.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=4.2m
                },
                new Product
                {
                    ProductId = 11,
                    CategoryId = 2,
                    RestaurantId=3,
                    ProductName = "Hawaiian",
                    ProductImg = "hawaiian",
                    ProductPrice = 17.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=3.7m
                },
                new Product
                {
                    ProductId = 12,
                    CategoryId = 2,
                    RestaurantId=4,
                    ProductName = "Marina",
                    ProductImg = "marina",
                    ProductPrice = 21.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=4.0m
                },
                new Product
                {
                    ProductId = 13,
                    CategoryId = 2,
                    RestaurantId=4,
                    ProductName = "Supreme",
                    ProductImg = "supreme",
                    ProductPrice = 29.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=3.9m
                },
                new Product
                {
                    ProductId = 14,
                    CategoryId = 2,
                    RestaurantId=4,
                    ProductName = "Vegetarian",
                    ProductImg = "vegetarian",
                    ProductPrice = 15.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=3.4m
                    
                },
                //
                //DESSERTS------------------------------------------------------
                //
                new Product
                {
                    ProductId = 15,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Belgium Cake",
                    ProductImg = "belgium",
                    ProductPrice = 12.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=5.0m
                },
                new Product
                {
                    ProductId = 16,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Brauni Tofeffee Cake",
                    ProductImg = "braunitofeffee",
                    ProductPrice = 27.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=35,
                    ProductRating=4.4m
                },
                new Product
                {
                    ProductId = 17,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Fruit Cake",
                    ProductImg = "fruit",
                    ProductPrice = 22.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=4.7m
                },
                new Product
                {
                    ProductId = 18,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Gansh",
                    ProductImg = "gansh",
                    ProductPrice = 12.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=4.8m
                },
                new Product
                {
                    ProductId = 19,
                    CategoryId = 3,
                    RestaurantId=6,
                    ProductName = "Nut Cake",
                    ProductImg = "nut",
                    ProductPrice = 79.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=40,
                    ProductRating=4.1m
                },
                new Product
                {
                    ProductId = 20,
                    CategoryId = 3,
                    RestaurantId=6,
                    ProductName = "Raffaella",
                    ProductImg = "raffaella",
                    ProductPrice = 29.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=30,
                    ProductRating=4.8m
                },
                new Product
                {
                    ProductId = 21,
                    CategoryId = 3,
                    RestaurantId=6,
                    ProductName = "Red Velvet",
                    ProductImg = "redvelvet",
                    ProductPrice = 69.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=4.2m
                },
                //
                //PANCAKES----------------------------------------------------------
                //
                new Product
                {
                    ProductId = 22,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "NIKO's Pancakes with Cheese",
                    ProductImg = "cheese",
                    ProductPrice = 5.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.2m
                },
                new Product
                {
                    ProductId = 23,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Verdi's Pancakes with Cheese",
                    ProductImg = "cheese2",
                    ProductPrice = 6.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=3.4m
                },
                new Product
                {
                    ProductId = 24,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Pancakes with Cheese and Jam",
                    ProductImg = "cheeseandjam",
                    ProductPrice = 7.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=2.9m
                },
                new Product
                {
                    ProductId = 25,
                    CategoryId = 3,
                    RestaurantId=5,
                    ProductName = "Pancakes with Chocolate",
                    ProductImg = "chocolate",
                    ProductPrice = 4.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=10,
                    ProductRating=4.4m
                },
                new Product
                {
                    ProductId = 26,
                    CategoryId = 3,
                    RestaurantId=6,
                    ProductName = "Pancakes with Honey",
                    ProductImg = "honey",
                    ProductPrice = 4.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=10,
                    ProductRating=3.6m
                },
                new Product
                {
                    ProductId = 27,
                    CategoryId = 3,
                    RestaurantId=6,
                    ProductName = "Pancakes with Jam",
                    ProductImg = "jam",
                    ProductPrice = 7.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.4m
                },
                new Product
                {
                    ProductId = 28,
                    CategoryId = 3,
                    RestaurantId=6,
                    ProductName = "Pancakes with Nutella",
                    ProductImg = "nutella",
                    ProductPrice = 9.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.1m
                },
                //
                //SUSHI-----------------------------------------------------------------
                //
                new Product
                {
                    ProductId = 29,
                    CategoryId = 4,
                    RestaurantId=7,
                    ProductName = "Burj Al Arab Combo",
                    ProductImg = "burjalarab",
                    ProductPrice = 44.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=30,
                    ProductRating=5.0m
                },
                new Product
                {
                    ProductId = 30,
                    CategoryId = 4,
                    RestaurantId=7,
                    ProductName = "Burj Khalifa Combo",
                    ProductImg = "burjkhalifa",
                    ProductPrice = 49.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=35,
                    ProductRating=4.0m
                },
                new Product
                {
                    ProductId = 31,
                    CategoryId = 4,
                    RestaurantId=7,
                    ProductName = "Cesar Combo",
                    ProductImg = "cesar",
                    ProductPrice = 49.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=35,
                    ProductRating=3.2m
                },
                new Product
                {
                    ProductId = 32,
                    CategoryId = 4,
                    RestaurantId=7,
                    ProductName = "Grand Chicken Combo",
                    ProductImg = "grandchicken",
                    ProductPrice = 29.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=3.9m
                },
                new Product
                {
                    ProductId = 33,
                    CategoryId = 4,
                    RestaurantId=8,
                    ProductName = "Japanese Sunrise Combo",
                    ProductImg = "japanesesunrise",
                    ProductPrice = 59.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=40,
                    ProductRating=3.9m
                },
                new Product
                {
                    ProductId = 34,
                    CategoryId = 4,
                    RestaurantId=8,
                    ProductName = "Philadelphia Combo",
                    ProductImg = "philadelphia",
                    ProductPrice = 33.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=30,
                    ProductRating=4.0m
                },
                new Product
                {
                    ProductId = 35,
                    CategoryId = 4,
                    RestaurantId=8,
                    ProductName = "Salmon Combo",
                    ProductImg = "salmon",
                    ProductPrice = 19.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=4.3m
                },
                //
                //MEXICAN-------------------------------------------------------
                //
                new Product
                {
                    ProductId = 36,
                    CategoryId = 5,
                    RestaurantId=9,
                    ProductName = "Beef Tacos",
                    ProductImg = "beeftacos",
                    ProductPrice = 12.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=4.6m
                },
                new Product
                {
                    ProductId = 37,
                    CategoryId = 5,
                    RestaurantId=9,
                    ProductName = "Carnitas Deserdo",
                    ProductImg = "carnitasdeserdo",
                    ProductPrice = 14.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=30,
                    ProductRating=4.5m
                },
                new Product
                {
                    ProductId = 38,
                    CategoryId = 5,
                    RestaurantId=9,
                    ProductName = "Chicken Tacos",
                    ProductImg = "chickentacos",
                    ProductPrice = 14.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=25,
                    ProductRating=4.1m
                },
                new Product
                {
                    ProductId = 39,
                    CategoryId = 5,
                    RestaurantId=9,
                    ProductName = "Chilli Konkarne",
                    ProductImg = "chillikonkarne",
                    ProductPrice = 17.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=3.2m
                },
                new Product
                {
                    ProductId = 40,
                    CategoryId = 5,
                    RestaurantId=10,
                    ProductName = "Enchiladas",
                    ProductImg = "enchiladas",
                    ProductPrice = 19.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=4.6m
                },
                new Product
                {
                    ProductId = 41,
                    CategoryId = 5,
                    RestaurantId=10,
                    ProductName = "Tacos Demar",
                    ProductImg = "tacosdemar",
                    ProductPrice = 8.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=15,
                    ProductRating=4.8m
                },
                new Product
                {
                    ProductId = 42,
                    CategoryId = 5,
                    RestaurantId=10,
                    ProductName = "Tacos Grande",
                    ProductImg = "tacosgrande",
                    ProductPrice = 12.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=3.8m
                },
                //
                //VEGETARIAN-------------------------------------------------------------
                //
                new Product
                {
                    ProductId = 43,
                    CategoryId = 6,
                    RestaurantId=5,
                    ProductName = "Fruit Veg Cake",
                    ProductImg = "fruitveg",
                    ProductPrice = 22.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=35,
                    ProductRating=4.7m
                },
                new Product
                {
                    ProductId = 44,
                    CategoryId = 6,
                    RestaurantId=2,
                    ProductName = "McVeggie",
                    ProductImg = "mcveggie",
                    ProductPrice = 15.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=3.1m
                },
                new Product
                {
                    ProductId = 45,
                    CategoryId = 6,
                    RestaurantId=4,
                    ProductName = "Vegetarian",
                    ProductImg = "vegetarian",
                    ProductPrice = 29.99m,
                    ProductDescritpion="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras sed arcu tempus, tincidunt neque id, elementum felis. Integer pharetra tellus nisl, at condimentum quam fringilla ut. Quisque et nulla gravida, auctor ipsum ut, auctor libero.",
                    ProductDeliveryTime=20,
                    ProductRating=3.4m
                },
            };
        }

        public async Task AddProductsAsync()
        {
            try
            {
               foreach(var product in Products)
                {
                    await client.Child("Products").PostAsync(new Product()
                    {
                        ProductId=product.ProductId,
                        CategoryId=product.CategoryId,
                        RestaurantId = product.RestaurantId,
                        ProductName=product.ProductName,
                        ProductImg=product.ProductImg,
                        ProductPrice=product.ProductPrice,
                        ProductDescritpion = product.ProductDescritpion,
                        ProductDeliveryTime=product.ProductDeliveryTime,
                        ProductRating=product.ProductRating
                    });
                }
            }
            catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
