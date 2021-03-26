using System;

namespace DesignPatternsLibrary.Composite
{
    public class CompositeItem : ICompositeComponent
    {
        private readonly string _name;
        public CompositeItem(string name)
        {
            _name = name;
        }

        public void AddComponent(ICompositeComponent newComponnent)
        {
        }

        public void DisplayComponents()
        {
            Console.WriteLine($"Item name: {_name}");
        }
    }
}