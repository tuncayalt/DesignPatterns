namespace DesignPatternsLibrary.Observer
{
    public interface IObserver
    {
         void Update<T>(T newValue);
         void Subscribe(IObservable observable);
    }
}