namespace GrantFoods.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public int CategoryId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantImg { get; set; }
        public string RestaurantDescription { get; set; }
        public string RestaurantLocation { get; set; }
        public decimal RestaurrantRating { get; set; }
    }
}
