using System.Collections.Generic;
using VetCommon;

namespace DogDataLogic
{
    public interface IDogDataService
    {
        List<DogCommon> GetDogs();
        void AddDog(DogCommon dog);
        bool AdoptDog(string name, string owner);
        bool RemoveDog(string name);
    }
}
