using System;
using DesignPatternsLibrary.Composite;
using DesignPatternsLibrary.FactoryMethod;
using DesignPatternsLibrary.Observer;
using System.Collections.Generic;
using Observable = DesignPatternsLibrary.Observer.Observable;
using IObservable = DesignPatternsLibrary.Observer.IObservable;
using static System.Console;
using DesignPatternsDemo.MediatorObjects;
using DesignPatternsLibrary.Mediators;
using Microsoft.Extensions.DependencyInjection;

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
            ObserverDemo();
            WriteLine("-----------");
            MediatorDemo();
        }

        private static async void MediatorDemo()
        {
            var serviceResolver = new ServiceCollection()
                .AddTransient<PrintSomethingHandler>()
                .BuildServiceProvider();

            var handlerDetails = new Dictionary<Type, Type>
            {
                [typeof(PrintSomethingRequest)] = typeof(PrintSomethingHandler)
            };

            var request = new PrintSomethingRequest
            {
                Text = "Something needed"
            };

            IMediator mediator = new Mediator(serviceResolver.GetRequiredService, handlerDetails);
            var response = await mediator.SendAsync(request);
            WriteLine(response);
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

        static void ObserverDemo()
        {
            IObservable observable = new Observable();

            var observer1 = new Observer();
            observer1.Subscribe(observable);

            var observer2 = new Observer();
            observer2.Subscribe(observable);

            observable.Notify(1);
            observable.Notify(5);
            observable.Notify("a");
        }
    }
}
