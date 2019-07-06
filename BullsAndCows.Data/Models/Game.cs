﻿using BullsAndCows.Data.Common;
using System;

namespace BullsAndCows.Data.Models
{
    public class Game : BaseModel<string>
    {
        public Game() : base()
        {
            this.Number = new Random().Next(1000, 9999);
            this.Status = GameStatus.Lost;
        }

        public int Number { get; set; }

        public GameStatus Status { get; set; }

        public string UserId { get; set; }
        public BullsAndCowsUser User { get; set; }
    }
}
