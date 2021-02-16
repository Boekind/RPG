using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Consumable : Item
    {
        public string Effect { get; set; }
        public int Amount { get; set; }

        public Consumable()
        {

        }

        public Consumable(string name, int value, string effect, int amount)
        {
            Name = name;
            Value = value;
            Effect = effect;
            Amount = amount;
        }
    }
}
