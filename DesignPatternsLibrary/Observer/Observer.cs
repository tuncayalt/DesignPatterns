using static System.Console;

namespace DesignPatternsLibrary.Observer
{
    public class Observer : IObserver
    {
        IObservable observable;

        public void Subscribe(IObservable observable)
        {
            this.observable = observable;
            observable.Subscribe(this);
        }

        public void Update<T>(T newValue)
        {
            WriteLine(newValue);
        }
    }
}