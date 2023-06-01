namespace GrantFoods.Models
{
    public class UserCartItem
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImg { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}
