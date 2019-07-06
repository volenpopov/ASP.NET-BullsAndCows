using System.Security.Claims;
using System.Threading.Tasks;

namespace BullsAndCows.Services.Contracts
{
    public interface IGamesService
    {
        Task<int> InitializeGame(ClaimsPrincipal principal);
    }
}
