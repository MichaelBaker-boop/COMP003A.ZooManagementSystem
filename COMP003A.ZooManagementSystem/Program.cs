// Author: Michael Baker
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
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
                    Program.OptionOne();
                    
                }
                
        
                
                if (menuSelection == 2)
                {
                    Console.WriteLine("Option 2");
                }
                if (menuSelection == 3)
                {
                    Program.OptionThree();
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
        public static void OptionOne() 
        {
            AnimalList animal = new AnimalList();


            bool validInput = false;


            Animal myLion = new Lion("Simba", "Mountain");
            while (!validInput)
            {

                Console.WriteLine("Enter the name of the lion: ");
                myLion.Name = Console.ReadLine();
                if (string.IsNullOrEmpty(myLion.Name))
                {
                    Console.WriteLine("The input cannot be null or empty");
                }
                else
                {
                    break;
                }
            }
            while (!validInput)
            {
                Console.WriteLine("Enter the species of the lion: ");
                myLion.Species = Console.ReadLine();
                if (string.IsNullOrEmpty(myLion.Species))
                {
                    Console.WriteLine("The input cannot be null or empty");
                }
                else
                {
                    validInput = true;
                }
            }

            Console.WriteLine($"{myLion.Name}, {myLion.Species}");
            animal.AddAnimal(myLion);
            Console.WriteLine("Lion added successfully");
        }
        public static void OptionTwo() { }
        public static void OptionThree()
        {
            AnimalList animal = new AnimalList();
            animal.DisplayAnimals();
        }
        
        

    }
}

