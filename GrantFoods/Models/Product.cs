

namespace GrantFoods.Models
{
    public partial class Product 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImg { get; set; }
        public string ProductDescritpion { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductDeliveryTime { get; set; }
        public int CategoryId { get; set; }
        public int RestaurantId { get; set; }
        public decimal ProductRating { get; set; }
    }
}
