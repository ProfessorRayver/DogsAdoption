using System.Collections.Generic;
using VetCommon;

namespace DogDataLogic
{
    public class AdoptionData
    {
        public List<DogCommon> Dogs { get; } = new List<DogCommon>();

        public void AddDog(DogCommon dog)
        {
            Dogs.Add(dog);
        }

        public bool AdoptDog(string name)
        {
            var dog = Dogs.Find(d => d.Name.ToLower() == name.ToLower());
            if (dog != null && dog.Status == "Available")
            {
                dog.Status = "Adopted";
                return true;
            }
            return false;
        }
    }
}
