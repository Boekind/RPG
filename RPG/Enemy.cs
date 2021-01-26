using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Enemy : Character
    {
        public Dictionary<Item, int> Loot { get; set; }
        public int MoneyLoot { get; set; }

        public Item GetLoot()
        {
            //Wahrscheinlichkeitszeug
        }
    }
}
