// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using System.Security.Cryptography.X509Certificates;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();
            int menuSelection = 0;
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
                    Animal myLion = new Lion("Simba", "Mountain");
                    Console.WriteLine("Enter the name of the lion: ");
                    myLion.Name = Console.ReadLine();
                    Console.WriteLine("Enter the species of the lion: ");
                    myLion.Species = Console.ReadLine();
                    Console.WriteLine($"{myLion.Name}, {myLion.Species}");
                    animal.Add(myLion);

                    Console.WriteLine("Lion added successfully");
        
                }
                if (menuSelection == 2)
                {
                    Console.WriteLine("Option 2");
                }
                if (menuSelection == 3)
                {
                    Console.WriteLine("Option 3");
                    Console.WriteLine("Animal List: ");
                    for (int i = 0; i < animal.Count; i++) 
                    {
                        Console.WriteLine($"{animal[i].Name}, {animal[i].Species}\n");
                    }
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

