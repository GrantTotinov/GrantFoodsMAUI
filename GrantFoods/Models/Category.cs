
namespace GrantFoods.Models
{
    public partial class Category : ObservableObject
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImg { get; set; }
    }
}
