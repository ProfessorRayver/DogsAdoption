namespace VetCommon
{
    public class DogCommon
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Status { get; set; } = "Pet Available"; // default status of dogs registered
        public string Owner { get; set; } = "NONE"; // the name of adopter 
    }
}
