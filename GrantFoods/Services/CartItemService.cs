namespace GrantFoods.Services
{
    public class CartItemService
    {
        public SQLiteAsyncConnection cn;
        public  async Task SetupDataBase()
        {
            if (cn != null)
                return;
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "GrantFoods.db3");
            cn = new SQLiteAsyncConnection(databasePath);
            await cn.CreateTableAsync<CartItem>();
        }

        public async Task AddCartItem(CartItem cartItem, int totalquantity)
        {
            await SetupDataBase();
            var ci = new CartItem
            {
                CartItemId = cartItem.CartItemId,
                ProductId = cartItem.ProductId,
                ProductName = cartItem.ProductName,
                ProductPrice = cartItem.ProductPrice,
                ProductImg = cartItem.ProductImg,
                Quantity = cartItem.Quantity
            };
            var item = await cn.Table<CartItem>().Where(c => c.ProductId == cartItem.ProductId).FirstOrDefaultAsync();
            if (item == null)
                await cn.InsertAsync(ci);
            else
            {
                item.Quantity = totalquantity;
                await cn.UpdateAsync(item);
            }
            await Shell.Current.DisplayAlert("Cart", "Selected Item is Added to the Cart", "OK");
        }

        public async Task DeleteCartItem(CartItem cartitem)
        {
            await SetupDataBase();
            await cn.DeleteAsync(cartitem);
        }

        public Task<int> GetCartItemsCount()
        {
            var count = cn.Table<CartItem>().CountAsync();
            return count;
        }
       
    }
}
