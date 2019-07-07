using BullsAndCows.Common;
using BullsAndCows.Data.Common;
using BullsAndCows.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BullsAndCows.Data
{
    public static class ApplicationDbContextSeeder
    {
        public static void SeedData(BullsAndCowsDbContext dbContext, UserManager<BullsAndCowsUser> userManager)
        {
            SeedUsers(dbContext, userManager);
            SeedGames(dbContext);
        }

        public static void SeedUsers(BullsAndCowsDbContext dbContext, UserManager<BullsAndCowsUser> userManager)
        {
            if (dbContext.Users.Count() == 0)
            {
                var usernames = new string[]
                {
                    "volenpopov", "pesho", "Gosho", "Kiro", "petkan99", "sandok@n", "BUrnaNDi", "HoneyBadger",
                    "NECtosiG", "Alfonso", "ninjaTurtle", "IvanIvanov", "icaguin", "mammoth@iceAge", "KhanKrum",
                    "POsTu", "Georgi", "Shmaizerov", "futboli$cheto", "Rasistat", "JohnDoe", "Johhny",
                    "bigJohhny", "littleJohhny", "Pavel", "mishoka", "CSKAA", "EagleEYE", "he@dSh0t",
                    "Beraen", "Xanthy", "mitkoPainera", "discoDJ", "chupacabra", "blackMamba", "zmiQta"
                };

                var password = "12345";

                foreach (var username in usernames)
                {
                    var user = new BullsAndCowsUser
                    {
                        UserName = username,
                    };

                    userManager.CreateAsync(user, password).Wait();
                }
            }
        }

        public static void SeedGames(BullsAndCowsDbContext dbContext)
        {
            if (dbContext.Games.Count() == 0)
            {
                var users = dbContext.Users.ToArray();

                var games = new HashSet<Game>();

                for (int i = 0; i < GlobalConstants.NumberOfGamesToSeed; i++)
                {
                    var randomUserIndex = new Random().Next(0, users.Length);
                    var gameStatus = i % 3 == 0
                        ? 2
                        : 1;

                    var game = new Game
                    {
                        Status = (GameStatus) gameStatus,
                        User = users[randomUserIndex]
                    };

                    games.Add(game);
                }

                dbContext.Games.AddRange(games);
                dbContext.SaveChanges();
            }
        }
    }
}
