using System;
using System.Collections.Generic;
using System.IO;
using VetCommon;

namespace DogDataLogic
{
    public class TextFileDogDataService : IDogDataService
    {
        private static string filePath = "dogs.txt";
        private List<DogCommon> dogs = new List<DogCommon>();

        public TextFileDogDataService()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            dogs.Clear();
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    dogs.Add(new DogCommon
                    {
                        Name = parts[0],
                        Breed = parts[1],
                        Status = parts[2]
                    });
                }
            }
        }

        private void SaveToFile()
        {
            var lines = new List<string>();
            foreach (var dog in dogs)
            {
                lines.Add($"{dog.Name}|{dog.Breed}|{dog.Status}");
            }
            File.WriteAllLines(filePath, lines);
        }

        public List<DogCommon> GetDogs() => new List<DogCommon>(dogs);

        public void AddDog(DogCommon dog)
        {
            dogs.Add(dog);
            SaveToFile();
        }

        public bool AdoptDog(string name)
        {
            var dog = dogs.Find(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (dog != null && dog.Status == "Available")
            {   
                dog.Status = "Adopted";
                SaveToFile();
                return true;
            }
            return false;
        }

        public bool RemoveDog(string name)
        {
            var dog = dogs.Find(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
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