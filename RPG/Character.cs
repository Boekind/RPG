using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    abstract class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string ImgUrl { get; set; }
        public int Hp { get; set; }
        public int BaseAttackDamage { get; set; }
        public Dictionary<string, int> Abilities { get; set; } //Als Klasse?
    }
}
