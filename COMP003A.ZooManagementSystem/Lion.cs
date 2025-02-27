namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        /// <summary>
        /// Constructs a lion with name and species.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public Lion(string name, string species)
        {
            Name = name;
            Species = species;
        }
        /// <summary>
        /// Shows the sound a lion makes.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("The lion roars!");
        }
    }
}
