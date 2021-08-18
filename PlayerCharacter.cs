using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonSlayer
{
    class PlayerCharacter
    {
        
        public int Health { get; set; }
        public int Loot { get; set; }
        public PlayerCharacter( int health = 100, int loot = 0)
        {
            Health = health;
            Loot = loot;
        }
        //public static void MoveCharacter()
        //{

        //}
    }
}
