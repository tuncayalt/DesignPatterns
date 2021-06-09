namespace DesignPatternsLibrary.Observer
{
    public interface IObservable
    {
         void Subscribe(IObserver observer);
         void Notify<T>(T newValue);
    }
}