﻿using System;

namespace Working_with_Nullable
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue; // magic number
            DaysSinceLastLogin = -1; // magic number
        }
    }
}
