﻿using System;

namespace Working_with_Nullable
{
    //class PlayerDisplayer
    //{
    //    public static void Write(PlayerCharacter player)
    //    {
    //        if (string.IsNullOrWhiteSpace(player.Name))
    //        {
    //            Console.WriteLine("Player name is null or all whitespace");
    //        }
    //        else
    //        {
    //            Console.WriteLine(player.Name);
    //        }

    //        int days = player.DaysSinceLastLogin ??  -1;//Null-coalescing Operator
    //        // int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1 ;Conditional Operator
    //        // int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
    //        Console.WriteLine($"{days} days since last login");

    //        //if (player.DaysSinceLastLogin.HasValue)
    //        //{
    //        //    Console.WriteLine(player.DaysSinceLastLogin.Value);                
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("No value for DaysSinceLastLogin");

    //        //}

    //        if (player.DateOfBirth.HasValue)
    //        {
    //         Console.WriteLine(player.DateOfBirth.Value);
    //        }
    //        else
    //        {Console.WriteLine("No date of birth specified");
    //        }

    //        if (!player.IsNoob.HasValue)
    //        {
    //            Console.WriteLine("Player newbie status is unknown");
    //        }
    //        else if (player.IsNoob == true)
    //        {
    //            Console.WriteLine("Player is a newbie");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Player is experienced");
    //        }
    //    }

    //}
}
