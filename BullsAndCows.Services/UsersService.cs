﻿using System.Linq;
using System.Threading.Tasks;
using BullsAndCows.Data;
using BullsAndCows.Data.Models;
using BullsAndCows.Models.BindingModels;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
    }
}