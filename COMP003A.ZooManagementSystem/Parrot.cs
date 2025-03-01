using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem
{
    internal class Parrot : Animal
    {

        public string ParrotName { get; set; }
        public string ParrotSpecies { get; set; }

        /// <summary>
        /// Constructs a parrot with name and species.
        /// </summary>
        /// <param name="nameParrot"></param>
        /// <param name="speciesParrot"></param>
        public Parrot(string nameParrot, string speciesParrot)
        {
            ParrotName = nameParrot;
            ParrotSpecies = speciesParrot;
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
