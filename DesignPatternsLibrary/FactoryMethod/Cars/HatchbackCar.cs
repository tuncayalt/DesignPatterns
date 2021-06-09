using static System.Console;

namespace DesignPatternsLibrary.FactoryMethod.Cars
{
    public class HatchbackCar : ICar
    {
        public void Display()
        {
            WriteLine("Looks like a Hatchback");
        }

        public void Drive()
        {
            WriteLine("Drives like a Hatchback");
        }
    }
}