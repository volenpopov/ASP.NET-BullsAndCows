using BullsAndCows.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace BullsAndCows.Data
{
    public static class ApplicationDbContextSeeder
    {
        public static void SeedUsers(BullsAndCowsDbContext dbContext, UserManager<BullsAndCowsUser> userManager)
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

                userManager.CreateAsync(user, password);
            }
        }
    }
}
