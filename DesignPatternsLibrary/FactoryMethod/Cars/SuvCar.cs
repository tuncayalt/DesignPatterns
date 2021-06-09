using static System.Console;

namespace DesignPatternsLibrary.FactoryMethod.Cars
{
    public class SuvCar : ICar
    {
        public void Display()
        {
            WriteLine("Looks like a SUV");
        }

        public void Drive()
        {
            WriteLine("Drives like a SUV");
        }
    }
}