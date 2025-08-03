using Interfaces;
namespace InterfaceSegregation
{
    public class Tester : IGeneralActivities, ITestActivities
    {
        public Tester()
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


        public void Test()
        {
            throw new ArgumentException();
        }
    }
}