using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Enemy : Character
    {
        public List<ItemLoot> Loot { get; set; }
        public int MoneyLoot { get; set; }

        public Enemy()
        {

        }

        public Enemy(string name, string aClass, int level, string imgUrl, int maxHp, int hp, int baseAttackDamage, List<Ability> abilities, List<ItemLoot> loot, int moneyLoot)
        {
            Name = name;
            ActiveClass = aClass;
            Level = level;
            ImgUrl = imgUrl;
            MaxHp = maxHp;
            Hp = hp;
            BaseAttackDamage = baseAttackDamage;
            Abilities = abilities;
            Loot = loot;
            MoneyLoot = moneyLoot;
        }

        public Item GetLoot()
        {
            //Wahrscheinlichkeitszeug
            return new Consumable();
        }
    }
}
