using System;
using DesignPatternsLibrary.Composite;
using DesignPatternsLibrary.FactoryMethod;
using System.Collections.Generic;
using static System.Console;

namespace DesignPatternsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            CompositeDemo();
            WriteLine("-----------");
            FactoryMethodDemo();
            WriteLine("-----------");
        }

        static void CompositeDemo()
        {
            ICompositeComponent group = new CompositeGroup("Animals");
            
            var turkeyCats = new CompositeGroup("Turkey Cats");
            turkeyCats.AddComponent(new CompositeItem("Van cat"));
            var pamuk = new CompositeItem("Pamuk");
            var cats = new CompositeGroup("Cats", new List<ICompositeComponent>{ turkeyCats, pamuk } );

            var bulldogs = new CompositeGroup("Bulldogs");
            bulldogs.AddComponent(new CompositeItem("Ugly"));
            var dogs = new CompositeGroup("Dogs");
            dogs.AddComponent(bulldogs);

            group.AddComponent(cats);
            group.AddComponent(dogs);

            group.DisplayComponents();
        }

        static void FactoryMethodDemo()
        {
            var factory = new CarFactory();
            
            var sedanCar = factory.CreateCar(CarType.Sedan);
            sedanCar.Display();
            sedanCar.Drive();

            var hatchbackCar = factory.CreateCar(CarType.Hatchback);
            hatchbackCar.Display();
            hatchbackCar.Drive();

            var suvCar = factory.CreateCar(CarType.Suv);
            suvCar.Display();
            suvCar.Drive();
        }
    }
}
