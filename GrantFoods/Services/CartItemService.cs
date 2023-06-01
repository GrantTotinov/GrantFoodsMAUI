

namespace GrantFoods.Services
{
    public class CartItemService
    {
        private readonly DatabaseService databaseService;
        public CartItemService(DatabaseService _databaseService)
        {
            databaseService = _databaseService;

        }
    }
}
