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
        public Inventory MyInventory { get; set; }
    }
}
