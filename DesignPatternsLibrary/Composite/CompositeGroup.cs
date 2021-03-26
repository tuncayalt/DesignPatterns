using System;
using System.Collections.Generic;

namespace DesignPatternsLibrary.Composite
{
    public class CompositeGroup : ICompositeComponent
    {
        private IList<ICompositeComponent> _compositeComponentList;
        private readonly string _groupName;

        public CompositeGroup(string groupName) : this(groupName, new List<ICompositeComponent>())
        {
        }

        public CompositeGroup(string groupName, IList<ICompositeComponent> compositeComponentList)
        {
            _groupName = groupName;
            _compositeComponentList = compositeComponentList;
        }

        public void AddComponent(ICompositeComponent newComponent)
        {
            _compositeComponentList.Add(newComponent);
        }

        public void DisplayComponents()
        {
            Console.WriteLine($"Group name: {_groupName}");

            foreach(var component in _compositeComponentList)
            {
                component.DisplayComponents();
            }
        }
    }
}