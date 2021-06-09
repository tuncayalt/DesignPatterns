using System;
using DesignPatternsLibrary.FactoryMethod.Cars;

namespace DesignPatternsLibrary.FactoryMethod
{
    public class CarFactory
    {
        public ICar CreateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Sedan:
                    return new SedanCar();
                case CarType.Hatchback:
                    return new HatchbackCar();
                case CarType.Suv:
                    return new SuvCar();
                default:
                    throw new InvalidOperationException("Car type not supported");
            }
        }
    }
}