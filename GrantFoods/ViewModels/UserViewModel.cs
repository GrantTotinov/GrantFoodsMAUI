namespace GrantFoods.ViewModels
{
    public partial class UserViewModel : BaseViewModel
    {
        UserService userService;

        [ObservableProperty]
        string userName;

        [ObservableProperty]
        string userPassword;

        [ObservableProperty]
        string userEmail;

        [ObservableProperty]
        bool result;

        [ObservableProperty]
        bool isUsernameValid;

        [ObservableProperty]
        bool isPasswordValid;

        [ObservableProperty]
        bool isEmailValid;

        public UserViewModel(UserService _userService)
        {
            userService = _userService;
        }

        [RelayCommand]
        private async Task RegisterAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                Result = await userService.RegisterUser(UserName, UserPassword, UserEmail);
                if (Result)
                {
                    await Shell.Current.DisplayAlert("Success", "The food is waiting for you", "OK");
                    await Shell.Current.GoToAsync(nameof(LandingView));
                }
                else
                {
                    await Shell.Current.DisplayAlert("Oops!", "Looks like user with this username already exists", "OK");
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("EROOR", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                Result = await userService.LoginUser(UserName, UserPassword);
                if (Result)
                {
                    Preferences.Set("Username", UserName);
                    await Shell.Current.GoToAsync($"//{nameof(HomeView)}");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Oops!", "Invalid Username or Password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("EROOR", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
