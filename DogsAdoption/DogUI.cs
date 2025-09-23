using System;
using DogDataLogic;

class DogUI
{
    static void Main(string[] args)
    {
        AdoptionLogic logic = new AdoptionLogic();

        while (true)
        {
            Console.WriteLine("\n=== Stray Dog Adoption System ===\n");
            Console.WriteLine("1. Add Dog");
            Console.WriteLine("2. Show Dogs");
            Console.WriteLine("3. Adopt Dog");
            Console.WriteLine("4. Remove Dog");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Dog Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Breed: ");
                string breed = Console.ReadLine();
                logic.AddDog(name, breed);
            }
            else if (choice == "2")
            {
                logic.ShowDogs();
            }
            else if (choice == "3")
            {
                Console.Write("Enter Dog Name to Adopt: ");
                string name = Console.ReadLine();
                logic.AdoptDog(name);
            }
            else if (choice == "4")
            {
                Console.Write("Enter Dog Name to Remove: ");
                string name = Console.ReadLine();
                logic.RemoveDog(name);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye, Thank you for visiting Rayver Adoption Center");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");
            }
        }
    }
}
