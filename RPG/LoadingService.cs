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
            ShopItems = LoadShopItems(ItemData);
        }

        public Dictionary<string, List<Item>> LoadItems()
        {
            var dataPathItems = Path.Combine(dataPath, "Items.json");
            var items = JsonConvert.DeserializeObject<Dictionary<string, List<Item>>>(File.ReadAllText(dataPathItems), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

            return items;
        }

        public List<Enemy> LoadEnemies()
        {
            var dataPathEnemies = Path.Combine(dataPath, "Enemies.json");
            var enemies = JsonConvert.DeserializeObject<List<Enemy>>(File.ReadAllText(dataPathEnemies), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

            return enemies;
        }

        public Hero LoadHero()
        {
            var dataPathHero = Path.Combine(dataPath, "Hero.json");
            var hero = JsonConvert.DeserializeObject<Hero>(File.ReadAllText(dataPathHero), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

            return hero;
        }

        public List<StoryText> LoadStory()
        {
            var dataPathStory = Path.Combine(dataPath, "Story.json");
            var story = JsonConvert.DeserializeObject<List<StoryText>>(File.ReadAllText(dataPathStory), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

            return story;
        }

        public List<Item> LoadShopItems(Dictionary<string, List<Item>> items)
        {
            var shopItems = new List<Item>();

            foreach (var item in items)
            {
                foreach (var i in item.Value)
                {
                    if (i.InShop)
                    {
                        shopItems.Add(i);
                    }
                }
            }

            return shopItems;
        }
    }
}
