using System.Collections.Generic;

namespace DesignPatternsLibrary.Observer
{
    public class Observable : IObservable
    {
        IList<IObserver> observers;

        public Observable()
        {
            observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify<T>(T newValue)
        {
            foreach (var observer in observers)
            {
                observer.Update(newValue);
            }
        }
    }
}