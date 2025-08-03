using Interfaces;
namespace InterfaceSegregation
{
    public class Developer : IGeneralActivities, IDeveloperActivities
    {
        public Developer()
        {
        }

        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }
        public void Design()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}