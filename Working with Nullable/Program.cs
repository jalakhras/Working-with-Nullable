using System;

namespace Working_with_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "jassar"},
            //    new PlayerCharacter(), // Name = null 
            //    null // PlayerCharacter = null
            //};

            PlayerCharacter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.ReadLine();
        }
    }
}
