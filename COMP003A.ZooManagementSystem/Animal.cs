namespace COMP003A.ZooManagementSystem
{
    public abstract class Animal
    {
        // Fields
        private string _name;
        private string _species;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Species
        { 
            get { return _species; } 
            set { _species = value; } 
        }

        public abstract void MakeSound();
        
    }
}
