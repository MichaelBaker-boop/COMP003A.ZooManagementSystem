namespace COMP003A.ZooManagementSystem
{
    public class Lion : Animal
    {
        public string LionName
        {
            get; set;
        }
        public string LionSpecies { get; set; }

        /// <summary>
        /// Constructs a lion with name and species.
        /// </summary>
        /// <param name="nameLion"></param>
        /// <param name="speciesLion"></param>
        public Lion(string nameLion, string speciesLion)
        {
            LionName = nameLion;
            LionSpecies = speciesLion;
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
