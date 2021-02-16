using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Weapon : Item
    {
        public int AttackDamage { get; set; }
        public string AllowedClass { get; set; }

        public Weapon()
        {

        }

        public Weapon(string name, int value, int attackDamage, string aClass)
        {
            Name = name;
            Value = value;
            AttackDamage = attackDamage;
            AllowedClass = aClass;
        }
    }
}
