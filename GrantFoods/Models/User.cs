namespace GrantFoods.Models
{
    public partial class User : ObservableObject
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
    }
}
