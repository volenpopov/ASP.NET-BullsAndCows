namespace BullsAndCows.Common
{
    public static class GlobalConstants
    {
        public const int PointsPerWin = 3;

        public const int MinFourDigitNumber = 1000;

        public const int MaxFourDigitNumber = 9999;

        public const int RankingCount = 25;

        public const string GAMES_TABLE_NAME = "Games";

        public const string DateFormat = "dd/MM/yyyy";

        public const string StringLengthErrorMsg = "{0} must be between {2} and {1} characters long!";

        public const string InvalidParameterErrorMsg = "Invalid {0}!";

        public const string FailedUserRegisterMsg = "Error: User already exists. Please, try again with different username.";

        public const string FailedLoginMsg = "Error: Invalid username or password!";
    }
}
