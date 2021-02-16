using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Hero : Character
    {
        public Weapon ActiveWeapon { get; set; }
        public int Mp { get; set; }
        public int Xp { get; set; }
        public int XpNextLevel { get; set; }
        public Inventory ActiveInventory { get; set; }

        public Hero()
        {

        }

        public Hero(string name, string activeClass, int level, string imgUrl, int maxHp, int hp, int baseAttackDamage, List<Ability> abilities, Weapon aWeapon, int mp, int xp, int xpNextLevel, Inventory aInventory) //Klasse HeroStats für kürzeren ctor
        {
            Name = name;
            ActiveClass = activeClass;
            Level = level;
            ImgUrl = imgUrl;
            MaxHp = maxHp;
            Hp = hp;
            BaseAttackDamage = baseAttackDamage;
            Abilities = abilities;
            ActiveWeapon = aWeapon;
            Mp = mp;
            Xp = xp;
            XpNextLevel = xpNextLevel;
            ActiveInventory = aInventory;
        }

        public void LevelUp()
        {

        }
    }
}
