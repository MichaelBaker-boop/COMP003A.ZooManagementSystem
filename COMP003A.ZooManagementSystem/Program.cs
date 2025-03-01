// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        public static void Main(string[] args)
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

                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Input invalid!");
                    Console.Write(ex.Message);
                    continue;
                }
                

                switch (menuSelection)
                {
                    case 1:

                        bool validInput = false; // Initialize test of user input

                        Animal myLion = new Lion("Simba", "Mountain"); // Create new Lion Object

                        while (!validInput) // While loop to get a name that is not null or empty
                        {
                            Console.Write("Enter the name of the lion: ");
                            myLion.Name = Console.ReadLine();
                            if (string.IsNullOrEmpty(myLion.Name))
                            {
                                Console.WriteLine("The name cannot be null or empty");
                            }
                            else
                            {
                                break;
                            }
                        }

                        while (!validInput) // While loop to get a species that is not null or empty
                        {
                            Console.Write("Enter the species of the lion: ");
                            myLion.Species = Console.ReadLine();
                            if (string.IsNullOrEmpty(myLion.Species))
                            {
                                Console.WriteLine("The species cannot be null or empty");
                            }
                            else
                            {
                                validInput = true;
                            }
                        }

                        Console.WriteLine($"{myLion.Name}, {myLion.Species}"); // Check inputs; remove or comment before submission
                        animal.Add(myLion);
                        Console.WriteLine("Lion added successfully");
                        break;

                    case 2:

                        bool validInput2 = false; // Initialize test of user input

                        Animal myParrot = new Parrot("Polly", "Pirate"); // Create new Parrot Object

                        while (!validInput2) // While loop to get a name that is not null or empty
                        {
                            Console.Write("Enter the name of the parrot: ");
                            myParrot.Name = Console.ReadLine();
                            if (string.IsNullOrEmpty(myParrot.Name))
                            {
                                Console.WriteLine("The name cannot be null or empty");
                            }
                            else
                            {
                                break;
                            }
                        }

                        while (!validInput2) // While loop to get a species that is not null or empty
                        {
                            Console.Write("Enter the species of the parrot: ");
                            myParrot.Species = Console.ReadLine();
                            if (string.IsNullOrEmpty(myParrot.Species))
                            {
                                Console.WriteLine("The species cannot be null or empty");
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine($"{myParrot.Name}, {myParrot.Species}"); // Check inputs; remove or comment before submission
                        animal.Add(myParrot);
                        Console.WriteLine("Parrot added successfully");
                        break;

                    case 3:

                        Console.WriteLine("Displaying all animals: ");
                        foreach (var animals in animal)
                        {
                            animals.MakeSound();
                            Console.WriteLine($"({animals.Name}, {animals.Species})");
                        }

                        break;
                    case 4:   

                        ZooUtility.DescribeAnimal("Simba");
                        ZooUtility.DescribeAnimal("Polly", "Pirate");
                        ZooUtility.DescribeAnimal("Edgar", "Elephant", 2);
                        break;
                    case 5:
                    
                        Console.WriteLine("Goodbye!");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select an available option.");
                        break;
                        
                }
            }

        }
   
        
        
        

    }
}

