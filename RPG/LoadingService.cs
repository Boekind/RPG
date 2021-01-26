using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class LoadingService
    {
        public List<Item> ItemData { get; set; }
        public List<Enemy> EnemyData { get; set; }
        public Hero HeroData { get; set; }
        public List<StoryText> StoryData { get; set; }

        public void LoadLists()
        {
            LoadItems();
            LoadEnemies();
            LoadHero();
            LoadStory();
        }

        public void LoadItems()
        {

        }

        public void LoadEnemies()
        {

        }

        public void LoadHero()
        {

        }

        public void LoadStory()
        {

        }
    }
}
