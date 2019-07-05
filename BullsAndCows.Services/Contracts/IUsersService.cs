using BullsAndCows.Models.BindingModels;
using System.Threading.Tasks;

namespace BullsAndCows.Services.Contracts
{
    public interface IUsersService
    {
        Task<bool> CreateUserAsync(UserBindingModel model);

        Task<bool> LoginUserAsync(UserLoginBindingModel model);
    }
}
