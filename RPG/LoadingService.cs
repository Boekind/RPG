using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace RPG
{
    class LoadingService
    {
        public string dataPath = Path.Combine(Environment.CurrentDirectory, "Data");
        public Dictionary<string, List<Item>> ItemData { get; set; }
        public List<Enemy> EnemyData { get; set; }
        public Hero HeroData { get; set; }
        public List<StoryText> StoryData { get; set; } //Vorerst nicht
        public List<Item> ShopItems { get; set; }

        public LoadingService()
        {
            LoadLists();
        }


        public void LoadLists()
        {
            ItemData = LoadItems();
            EnemyData = LoadEnemies();
            HeroData = LoadHero();
            StoryData = LoadStory();
            ShopItems = LoadShopItems();
        }

        public Dictionary<string, List<Item>> LoadItems()
        {
            var dataPathItems = Path.Combine(dataPath, "Items.json");
            var items = JsonConvert.DeserializeObject<Dictionary<string, List<Item>>>(File.ReadAllText(dataPathItems), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });


            return items;
        }

        public List<Enemy> LoadEnemies()
        {
            EnemyData = new List<Enemy>();
           

            return new List<Enemy>();
        }

        public Hero LoadHero()
        {
            

            return new Hero();
        }

        public List<StoryText> LoadStory()
        {
            var l = new List<StoryText>();
            

            return new List<StoryText>();
        }

        public List<Item> LoadShopItems()
        {
            var l = new List<Item>();
           

            return new List<Item>();
        }
    }
}
