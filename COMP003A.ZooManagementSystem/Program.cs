// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = 0;
            List<string> animalNames = new List<string>();
            List<string> animalSpecies = new List<string>();
            List<int> animalAges = new List<int>();
            Console.WriteLine("Welcome to the Zoo Management System!");

            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");

                menuSelection = int.Parse(Console.ReadLine());


                if (menuSelection == 1)
                {
                    Console.WriteLine("Option 1");
                    Console.WriteLine("Name of Lion: ");
                    animalNames.Add(Console.ReadLine());
                    Console.WriteLine("Species of Lion: ");
                    animalSpecies.Add(Console.ReadLine());
                    Console.WriteLine("Age of Lion: ");
                    animalAges.Add(int.Parse(Console.ReadLine()));
                }
                if (menuSelection == 2)
                {
                    Console.WriteLine("Option 2");
                }
                if (menuSelection == 3)
                {
                    Console.WriteLine("Option 3");
                }
                if (menuSelection == 4)
                {
                    Console.WriteLine("Option 4");
                }
                if (menuSelection == 5)
                {
                    Console.WriteLine("Goodbye!");
                    menu = false;
                }
            }

        }
        

    }
}
