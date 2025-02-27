using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem
{
    internal class Parrot : Animal
    {
        /// <summary>
        /// Constructs a parrot with name and species.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public Parrot(string name, string species)
        {
            Name = name;
            Species = species;
        }
        /// <summary>
        /// Shows the sound a parrot makes.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("The parrot squawks!");
        }
    }
}
