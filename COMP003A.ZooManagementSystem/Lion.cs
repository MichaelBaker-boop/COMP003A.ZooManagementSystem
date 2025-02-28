namespace COMP003A.ZooManagementSystem
{
    public class Lion : Animal
    {
        public string LionName
        {
            get 
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(Name))
                    {
                        throw new InvalidDataException("The name cannot be null or empty. Please try again.");
                    }
                    return Name;
                }
                catch (Exception e)
                {
                 
                    Console.WriteLine($"Invalid input: {e.Message}");
                    throw e;
                }
                
            }
            set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new InvalidDataException(nameof(value));
                    }
                    Name = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid input: {e.Message}");
                }
            }
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
