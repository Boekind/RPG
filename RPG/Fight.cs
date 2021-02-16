using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Fight
    {
        public Hero ActiveHero { get; set; }
        public int ActiveEnemy { get; set; }

        public Fight()
        {

        }

        public Enemy GetRandomEnemy(int level)
        {
            return new Enemy();
        }

        public Enemy GetEnemy(string name, int level)
        {
            return new Enemy();
        }
    }
}
