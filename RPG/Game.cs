﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        public LoadingService LoadServ { get; set; }

        public Game()
        {
            LoadServ = new LoadingService();
        }

        public void StartGame()
        {

        }

        public void SaveGame()
        {

        }
    }
}
