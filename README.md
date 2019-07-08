# Bulls And Cows - Guess the 4-digit number

## Tech Stack: ASP.NET Core MVC 2.2, EF Core, SQL Server, JavaScript, Bootstrap

### Summary:

**Guest users** can view the top 25 ranking and also create an account.

**Registered users** can login, view their profile, delete their account, and play the game. User profile contains info about: user register date and game stats (wins, losses, total games, total points, win/loss ratio).

**Playing the game** - the user has 8 tries to guess a randomly generated 4-digit number. On each try he/she will receive info about how many bulls and cows he/she managed to guess. A cow is a number that is present in the answer. A bull is a number that is present in the answer and also that is at the correct position. If the user wins he will get 3 points added to his score.  

Note: 35 users and 150 games have been seeded in development mode. At start you can pick any username from the top 25 and login with password: 12345.
