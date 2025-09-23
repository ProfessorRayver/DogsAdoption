using System.Collections.Generic;
using VetCommon;

namespace DogDataLogic
{
    public class InMemoryDogDataService : IDogDataService
    {
        private List<DogCommon> dogs = new List<DogCommon>();

        public List<DogCommon> GetDogs() => dogs;

        public void AddDog(DogCommon dog) => dogs.Add(dog);

        public bool AdoptDog(string name)
        {
            var dog = dogs.Find(d => d.Name.ToLower() == name.ToLower());
            if (dog != null && dog.Status == "Available")
            {
                dog.Status = "Adopted";
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
                return true;
            }
            return false;
        }
    }
}
