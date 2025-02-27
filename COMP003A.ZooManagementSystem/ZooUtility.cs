namespace COMP003A.ZooManagementSystem
{
    internal class ZooUtility
    {

        public string DescribeAnimal(string name)
        {
            return name;
        }

        public string DescribeAnimal(string name, string species)
        {
            return name + species;
        }

        public string DescribeAnimal(string name, string species, int age)
        {
            return name + species + age;
        }

    }
}
