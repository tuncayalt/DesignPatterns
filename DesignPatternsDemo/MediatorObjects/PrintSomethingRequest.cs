using DesignPatternsLibrary.Mediators;

namespace DesignPatternsDemo.MediatorObjects
{
    public class PrintSomethingRequest : IRequest<bool>
    {
        public string Text { get; set; }
    }
}
