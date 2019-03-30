using System;

namespace Working_with_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = null;// "Jassar";
            player.DaysSinceLastLogin = 42;


            PlayerDisplayer.Write(player);


            Console.ReadLine();
        }
    }
}
