using static System.Console;

namespace DesignPatternsLibrary.FactoryMethod.Cars
{
    public class SedanCar : ICar
    {
        public void Display()
        {
            WriteLine("Looks like a Sedan");
        }

        public void Drive()
        {
            WriteLine("Drives like a Sedan");
        }
    }
}