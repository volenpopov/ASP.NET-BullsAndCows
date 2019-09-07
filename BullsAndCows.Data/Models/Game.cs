using BullsAndCows.Common;
using BullsAndCows.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BullsAndCows.Data.Models
{
    [Table(GlobalConstants.GAMES_TABLE_NAME)]
    public class Game : BaseModel<string>
    {
        public Game() : base()
        {
            this.Number = new Random().Next(GlobalConstants.MinFourDigitNumber, GlobalConstants.MaxFourDigitNumber);
            this.Status = GameStatus.Lost;
        }

        public int Number { get; set; }

        public GameStatus Status { get; set; }

        [Required]
        public string UserId { get; set; }
        public BullsAndCowsUser User { get; set; }
    }
}
