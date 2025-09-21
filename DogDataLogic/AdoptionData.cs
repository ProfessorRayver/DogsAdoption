using System.Collections.Generic;

namespace DogDataLogic
{
    public class AdoptionData
    {
        public List<Dog> Dogs { get; } = new List<Dog>();

        public class Dog
        {
            public string Name { get; }
            public string Breed { get; }
            public string Status { get; set; }

            public Dog(string name, string breed)
            {
                Name = name;
                Breed = breed;
                Status = "Available";
            }
        }

        public void AddDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public bool RemoveDog(string name)
        {
            var dog = Dogs.Find(d => d.Name == name);
            if (dog != null)
            {
                Dogs.Remove(dog);
                return true;
            }
            return false;
        }
    }
}
