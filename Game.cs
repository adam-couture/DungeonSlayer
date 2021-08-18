using System;

namespace DungeonSlayer
{
    class Game
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome Dungeon Slayer!!!");

            PlayerCharacter slayer = new PlayerCharacter();

            Console.WriteLine("Press \"Enter\" to move");

            bool ContinuePlay = true;

            while (ContinuePlay = true)
            {


                if (slayer.Health != 0)
                {
                    
                }
                Console.WriteLine("Your current health is" + slayer.Health);
                Console.WriteLine("Your current loot is" + slayer.Loot);

                Console.WriteLine("Would you like to move again or end? (move/end)");
                string answer = Console.ReadLine();
                if (answer == "end")
                {
                    break;
                }
                if (answer == "move")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Answer must be \"move\" or \"end\"");

                }
            }

        }
    }
}
