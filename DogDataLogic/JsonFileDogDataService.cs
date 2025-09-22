using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using VetCommon;

namespace DogDataLogic
{
    public class JsonFileDogDataService : IDogDataService
    {
        private static string filePath = "dogs.json";
        private List<DogCommon> dogs = new List<DogCommon>();

        public JsonFileDogDataService()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                dogs = JsonSerializer.Deserialize<List<DogCommon>>(json) ?? new List<DogCommon>();
            }
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(dogs, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<DogCommon> GetDogs() => dogs;

        public void AddDog(DogCommon dog)
        {
            dogs.Add(dog);
            SaveToFile();
        }

        public bool AdoptDog(string name, string owner)
        {
            var dog = dogs.Find(d => d.Name.ToLower() == name.ToLower());
            if (dog != null && dog.Status == "Available")
            {
                dog.Status = "Adopted";
                dog.Owner = owner;
                SaveToFile();
                return true;
            }
            return false;
        }

        public bool RemoveDog(string name)
        {
            var dog = dogs.Find(d => d.Name.ToLower() == name.ToLower());
            if (dog != null)
            {
                dogs.Remove(dog);
                SaveToFile();
                return true;
            }
            return false;
        }
    }
}
