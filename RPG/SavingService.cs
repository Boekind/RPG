using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPG
{
    class SavingService
    {
        public string dataPath = Path.Combine(Environment.CurrentDirectory, "Data");


        public void SaveHero(Hero hero)
        {
            var dataPathHero = Path.Combine(dataPath, "Hero.json");
            string jsonText = JsonConvert.SerializeObject(hero, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(dataPathHero, jsonText);
        }
    }
}
