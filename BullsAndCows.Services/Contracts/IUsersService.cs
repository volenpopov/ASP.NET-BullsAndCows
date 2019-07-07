using BullsAndCows.Models.BindingModels;
using BullsAndCows.Models.ViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BullsAndCows.Services.Contracts
{
    public interface IUsersService
    {
        Task<bool> CreateUserAsync(UserBindingModel model);

        Task<bool> LoginUserAsync(UserLoginBindingModel model);

        Task LogoutUserAsync();

        Task<UserProfileViewModel> GetLoggedUserModelAsync(ClaimsPrincipal principal);

        Task<UserListRankingViewModel> GetTop25Async();

        Task<int> GetUserScoreAsync(ClaimsPrincipal principal);

        Task DeleteUserAsync(string username);
    }
}
