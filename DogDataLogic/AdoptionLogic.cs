using VetCommon;

namespace DogDataLogic
{
    public class AdoptionLogic
    {
        private readonly IDogDataService data;

        public AdoptionLogic()
        {
            // Switch here: InMemory or JsonFile
            // data = new InMemoryDogDataService();
            data = new JsonFileDogDataService();
        }

        public void AddDog(string name, string breed)
        {
            data.AddDog(new DogCommon { Name = name, Breed = breed });
            Console.WriteLine($"{name} ({breed}) has been added for adoption.");
        }

        public void ShowDogs()
        {
            var dogs = data.GetDogs();
            if (dogs.Count == 0)
            {
                Console.WriteLine("No dogs available for adoption.");
                return;
            }

            Console.WriteLine("\nDogs List:");
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog.Name} - {dog.Breed} - {dog.Status} - Owner: {dog.Owner}");
            }
        }

        public void AdoptDog(string name, string owner)
        {
            if (data.AdoptDog(name, owner))
            {
                Console.WriteLine($"{owner} has adopted {name}!");
            }
            else
            {
                Console.WriteLine("Dog not found or already adopted.");
            }
        }

        public void RemoveDog(string name)
        {
            if (data.RemoveDog(name))
            {
                Console.WriteLine($"{name} has been removed from the system.");
            }
            else
            {
                Console.WriteLine("Dog not found.");
            }
        }
    }
}
