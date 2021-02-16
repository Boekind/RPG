using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        public LoadingService LoadServ { get; set; }
        public Shop shop { get; set; }

        public Game()
        {
            LoadServ = new LoadingService();
            shop = new Shop(LoadServ.ShopItems);
        }

        public void StartGame()
        {

        }

        public void SaveGame()
        {

        }

        //public void UpdateUi()
        //{

        //}
    }
}
