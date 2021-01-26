using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Inventory
    {
        public Dictionary<Item, int> Items { get; set; }
        public int Money { get; set; }
    }
}
