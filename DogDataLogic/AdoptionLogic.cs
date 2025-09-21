using System;

namespace DogDataLogic
{
    public class AdoptionLogic
    {
        private readonly AdoptionData data = new();

        public void AddDog(string name, string breed)
        {
            data.AddDog(new AdoptionData.Dog(name, breed));
            Console.WriteLine("Dog added successfully.");
        }

        public void ShowDogs()
        {
            if (data.Dogs.Count == 0)
            {
                Console.WriteLine("No dogs available.");
                return;
            }
            foreach (var dog in data.Dogs)
            {
                Console.WriteLine($"{dog.Name} - {dog.Breed}");
            }
        }

        public void AdoptDog(string name)
        {
            if (data.RemoveDog(name))
            {
                Console.WriteLine($"{name} has been adopted!");
            }
            else
            {
                Console.WriteLine("Dog not found.");
            }
        }
    }
}
