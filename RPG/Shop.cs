using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Shop
    {
        public List<Item> ShopItems { get; set; }

        public Shop(List<Item> shopItems)
        {
            ShopItems = shopItems;
        }
        public void BuyItem(Item item)
        {

        }

        public void SellItem(Item item)
        {

        }
    }
}
