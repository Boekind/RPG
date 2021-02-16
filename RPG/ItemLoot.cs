using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class ItemLoot
    {
        public Item ItemDrop { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }

        public ItemLoot()
        {

        }

        public ItemLoot(Item itemDrop, int minA, int maxA)
        {
            ItemDrop = itemDrop;
            MinAmount = minA;
            MaxAmount = maxA;
        }
    }
}
