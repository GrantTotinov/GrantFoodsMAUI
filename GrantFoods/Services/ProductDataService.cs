
namespace GrantFoods.Services
{
    public class ProductDataService
    {
        FirebaseClient client;
        public ProductDataService()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products = (await client.Child("Products").OnceAsync<Product>()).Select(p => new Product
            {
                ProductId=p.Object.ProductId,
                CategoryId=p.Object.CategoryId,
                RestaurantId=p.Object.RestaurantId,
                ProductName=p.Object.ProductName,
                ProductImg=p.Object.ProductImg,
                ProductPrice=p.Object.ProductPrice,
                ProductDescritpion=p.Object.ProductDescritpion,
                ProductDeliveryTime=p.Object.ProductDeliveryTime,
                ProductRating=p.Object.ProductRating

            }).ToList();
            return products;
        }
        //products by categories
        public async Task<ObservableCollection<Product>> GetProductsByCategoriesAsync(int categoryId)
        {
            var productsbycategories = new ObservableCollection<Product>();
            var items = (await GetProductsAsync()).Where(p => p.CategoryId == categoryId).ToList();
            foreach (var item in items)
            {
                productsbycategories.Add(item);
            }
            return productsbycategories;
        }
        //top rated products
        public async Task<ObservableCollection<Product>> GetTopRatedProductsAsync()
        {
            var topratedproducts = new ObservableCollection<Product>();
            var itmes = (await GetProductsAsync()).OrderByDescending(p => p.ProductRating).ToList();
            foreach ( var item in itmes)
            {
                topratedproducts.Add(item);
            }
            return topratedproducts;
        }
        //offers
        public async Task<ObservableCollection<Product>> GetProductsbyPriceDec()
        {
            var productsbypricedec = new ObservableCollection<Product>();
            var items = (await GetProductsAsync()).OrderBy(p => p.ProductPrice).ToList();
            foreach(var item in items)
            {
                productsbypricedec.Add(item);
            }
            return productsbypricedec;
        }

        public async Task<ObservableCollection<Product>> GetProductsByRestaurantsAsync(int restaurantId)
        {
            var producysbyrestaurants = new ObservableCollection<Product>();
            var items = (await GetProductsAsync()).Where(p => p.RestaurantId == restaurantId).ToList();
            foreach (var item in items)
            {
                producysbyrestaurants.Add(item);
            }
            return producysbyrestaurants;
        }
    }
}
