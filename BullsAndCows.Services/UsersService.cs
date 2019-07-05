using System.Threading.Tasks;
using BullsAndCows.Data;
using BullsAndCows.Data.Models;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace BullsAndCows.Services
{
    public class UsersService : IUsersService
    {
        private readonly BullsAndCowsDbContext dbContext;
        private readonly UserManager<BullsAndCowsUser> userManager;

        public UsersService(BullsAndCowsDbContext dbContext, UserManager<BullsAndCowsUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public Task CreateUserAsync()
        {
            
        }
    }
}
