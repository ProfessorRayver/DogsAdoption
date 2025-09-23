using DogDataLogic;

namespace GUIdogAdoption
{
    public static class DataServiceProvider
    {
        public static JsonFileDogDataService DogDataService { get; } = new JsonFileDogDataService();
    }
}