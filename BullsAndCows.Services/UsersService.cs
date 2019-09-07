using BullsAndCows.Common;
using BullsAndCows.Data;
using BullsAndCows.Data.Models;
using BullsAndCows.Models.BindingModels;
using BullsAndCows.Models.ViewModels;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
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
            var user = await this.dbContext.Users
                .SingleOrDefaultAsync(usr => usr.UserName == model.Username);

            if (user != null)
            {
                if (!user.IsDeleted)
                {
                    var loginResult = await this.signInManager
                    .PasswordSignInAsync(model.Username, model.Password, false, lockoutOnFailure: false);

                    if (loginResult.Succeeded)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public async Task LogoutUserAsync()
        {
            await this.signInManager.SignOutAsync();
        }

        private async Task<BullsAndCowsUser> GetLoggedUserAsync(ClaimsPrincipal principal)
        {
            var userId = this.userManager.GetUserId(principal);

            return await this.dbContext.Users
                .Include(usr => usr.Games)
                .FirstOrDefaultAsync(usr => usr.Id == userId);
        }

        public async Task<UserProfileViewModel> GetLoggedUserModelAsync(ClaimsPrincipal principal)
        {
            var user = await this.GetLoggedUserAsync(principal);

            var userProfileViewMdel = new UserProfileViewModel
            {
                Username = user.UserName,
                CreatedOn = user.CreatedOn.ToString(GlobalConstants.DateFormat, CultureInfo.InvariantCulture),
                Wins = user.Wins,
                Losses = user.Losses,
                TotalPoints = user.TotalPoints,
                TotalGames = user.TotalGames,
                WinLossRatio = $"{user.WinLossRatio:f1}%"
            };
           
            return userProfileViewMdel;
        }

        public async Task<UserListRankingViewModel> GetTop25Async()
        {
            var allUsers = await this.dbContext.Users
                .Include(user => user.Games)
                .Where(user => !user.IsDeleted)
                .ToArrayAsync();

            var topUsers = allUsers
                .Where(user => user.TotalPoints > 0)
                .OrderByDescending(user => user.TotalPoints)
                .ThenByDescending(user => user.WinLossRatio)
                .ThenBy(user => user.TotalGames)
                .ThenBy(user => user.CreatedOn)
                .Take(GlobalConstants.RankingCount)
                .ToArray();
              
            var userRankingList = new List<UserRankingViewModel>(GlobalConstants.RankingCount);

            foreach (var user in topUsers)
            {
                var userRankingViewModel = new UserRankingViewModel
                {
                    Username = user.UserName,
                    Wins = user.Wins,
                    Losses = user.Losses,
                    TotalPoints = user.TotalPoints,
                    TotalGames = user.TotalGames,
                    WinLossRatio = $"{user.WinLossRatio:f1}%"
                };

                userRankingList.Add(userRankingViewModel);
            }

            return new UserListRankingViewModel { Users = userRankingList};
        }

        public async Task<int> GetUserScoreAsync(ClaimsPrincipal principal)
        {
            var user = await this.GetLoggedUserAsync(principal);

            return user.TotalPoints;            
        }

        public async Task DeleteUserAsync(string username)
        {
            var user = await this.dbContext.Users
                .SingleOrDefaultAsync(usr => usr.UserName == username);

            user.IsDeleted = true;
            user.DeletedOn = DateTime.UtcNow;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
