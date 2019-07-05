using BullsAndCows.Data;
using BullsAndCows.Data.Models;
using BullsAndCows.Models.BindingModels;
using BullsAndCows.Models.ViewModels;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BullsAndCows.Services
{
    public class UsersService : IUsersService
    {
        private readonly BullsAndCowsDbContext dbContext;
        private readonly UserManager<BullsAndCowsUser> userManager;
        private readonly SignInManager<BullsAndCowsUser> signInManager;

        public UsersService(
            BullsAndCowsDbContext dbContext, 
            UserManager<BullsAndCowsUser> userManager,
            SignInManager<BullsAndCowsUser> signInManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<bool> CreateUserAsync(UserBindingModel model)
        {
            var user = new BullsAndCowsUser
            {
                UserName = model.Username,                
            };

            var creationResult = await this.userManager.CreateAsync(user, model.Password);

            if (creationResult.Succeeded)
            {                
                return true;
            };
            
            return false;
        }

        public async Task<bool> LoginUserAsync(UserLoginBindingModel model)
        {
            var loginResult = await this.signInManager
                .PasswordSignInAsync(model.Username, model.Password, false, lockoutOnFailure: false);

            if (loginResult.Succeeded)
            {
                return true;
            }

            return false;
        }

        public async Task LogoutUserAsync()
        {
            await this.signInManager.SignOutAsync();
        }

        public async Task<UserProfileViewModel> GetLoggedUserModelAsync(ClaimsPrincipal principal)
        {
            var user = await this.userManager.GetUserAsync(principal);

            var userProfileViewMdel = new UserProfileViewModel
            {
                Username = user.UserName,
                CreatedOn = user.CreatedOn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                Wins = user.Wins,
                Losses = user.Losses,
                TotalPoints = user.TotalPoints                              
            };
           
            return userProfileViewMdel;
        }

        public async Task<UserListRankingViewModel> GetTop25()
        {
            var topUsers = await this.dbContext.Users
                .OrderByDescending(user => user.TotalPoints)
                .ThenByDescending(user => user.WinLossRatio)
                .ThenBy(user => user.TotalGames)
                .ThenBy(user => user.UserName)
                .Take(25)
                .ToArrayAsync();

            var userRankingList = new List<UserRankingViewModel>(25);

            foreach (var user in topUsers)
            {
                var userRankingViewModel = new UserRankingViewModel
                {
                    Username = user.UserName,
                    Wins = user.Wins,
                    Losses = user.Losses,
                    TotalPoints = user.TotalPoints
                };

                userRankingList.Add(userRankingViewModel);
            }

            return new UserListRankingViewModel { Users = userRankingList};
        }
    }
}
