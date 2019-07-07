using BullsAndCows.Models.ViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BullsAndCows.Services.Contracts
{
    public interface IGamesService
    {
        Task<GameViewModel> InitializeGameAsync(ClaimsPrincipal principal);

        Task ChangeGameStatusToWonAsync(string gameId);        
    }
}
