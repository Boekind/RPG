using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Consumable : Item
    {
        public string Effect { get; set; }
        public int Amount { get; set; }
    }
}
