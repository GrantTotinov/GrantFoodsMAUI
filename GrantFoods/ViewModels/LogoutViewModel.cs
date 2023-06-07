using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.ViewModels
{
    public partial class LogoutViewModel : BaseViewModel
    {
        private readonly DatabaseService databaseService;

        [ObservableProperty]
        int userCartItemsCountLogOut;

        [ObservableProperty]
        bool isCartExisting;
        
        public LogoutViewModel(DatabaseService _databaseService)
        {
            databaseService = _databaseService;
            

        }
        [RelayCommand]
        private async Task LogoutUserAsync()
        {
            var cartitems = await databaseService.GetAllAsync<CartItem>();
            foreach (var item in cartitems)
            {
                await databaseService.DeleteItemAsync(item);
            }
            Preferences.Remove("Username");
            await Shell.Current.GoToAsync(nameof(LandingView));
        }
        [RelayCommand]
        private async Task GotoCartFromLogoutAsync()
        {
            await Shell.Current.GoToAsync(nameof(CartView));
        }
        [RelayCommand]
        private async Task GoToLogoutViewAsync()
        {
            await Shell.Current.GoToAsync(nameof(LogoutView));
        }

        public async Task<int> ReturnCount()
        {
            var task = databaseService.GetTableCount<CartItem>();
            UserCartItemsCountLogOut = await task;
            return UserCartItemsCountLogOut;
            
        }

        public async Task<bool> IsCartExistingMethod()
        {
            await ReturnCount();
            IsCartExisting = (UserCartItemsCountLogOut > 0) ? true : false;
            return IsCartExisting;

        }
    }
}
