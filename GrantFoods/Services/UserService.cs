

namespace GrantFoods.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://grantfoodsnew-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        //proverqvam dali ima potebitel sus sushtestvuvash username
        public async Task<bool> IsUserExisting(string username)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.UserName == username).FirstOrDefault();
            return user != null;
        }

        //registrirane na potrebitel
        public async Task<bool> RegisterUser(string username, string password, string email)
        {
            if(await IsUserExisting(username) == false)
            {
                await client.Child("Users").PostAsync(new User()
                {
                    UserId = Guid.NewGuid().ToString(),
                    UserName = username,
                    UserPassword = password,
                    UserEmail = email
                });
                return true;
            }
            else
            {
                return false;
            }
        }

        //login na potrebitel
        public async Task<bool> LoginUser(string username, string password)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u=>u.Object.UserName == username).Where(u=>u.Object.UserPassword==password).FirstOrDefault();
          
            return user != null;
        }
    }
}
