using System;

namespace Working_with_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter jassar = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Jassar"
            };

            PlayerCharacter hussam = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Hussam"
            };

            PlayerCharacter jaffar = new PlayerCharacter(new NullDefence())
            {
                Name = "Jaffar"
            };

            jassar.Hit(10);
            hussam.Hit(10);
            jaffar.Hit(10);


            Console.ReadLine();
        }
    }
}
