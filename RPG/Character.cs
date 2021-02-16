using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    abstract class Character
    {
        public string Name { get; set; }
        public string ActiveClass { get; set; }
        public int Level { get; set; }
        public string ImgUrl { get; set; }
        public int MaxHp { get; set; }
        public int Hp { get; set; }
        public int BaseAttackDamage { get; set; }
        public List<Ability> Abilities { get; set; } 

      
    }
}
