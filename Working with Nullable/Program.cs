using System;

namespace Working_with_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter() ;
            player.DaysSinceLastLogin = 42;
            int days = player?.DaysSinceLastLogin ?? -1;
            //if (player !=null)
            //{
            //    days = player.DaysSinceLastLogin ?? -1;
            //}
            //else
            //{
            //    days = -1;
            //}
            Console.WriteLine(days);



            Console.ReadLine();
        }
    }
}
