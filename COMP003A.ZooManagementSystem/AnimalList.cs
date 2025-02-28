namespace COMP003A.ZooManagementSystem
{
    
    public class AnimalList
    {
        // Declare the list as a class level field
        private List<Animal> myanimals;

       // Constructor to initialize the list
        public AnimalList()
        {
            myanimals = new List<Animal>();
        }

        // Method to add an item to the list
        public void AddAnimal(Animal animal)
        {
            myanimals.Add(animal);
        }

        // Method to display list
        public void DisplayAnimals()
        {
            foreach (var item in myanimals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
