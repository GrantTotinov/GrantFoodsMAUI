namespace GrantFoods.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string UserName { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
