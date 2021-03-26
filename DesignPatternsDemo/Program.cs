using System;
using DesignPatternsLibrary.Composite;
using System.Collections.Generic;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeDemo();
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
    }
}
