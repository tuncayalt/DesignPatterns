using DesignPatternsLibrary.Mediators;
using System;
using System.Threading.Tasks;

namespace DesignPatternsDemo.MediatorObjects
{
    public class PrintSomethingHandler : IHandler<PrintSomethingRequest, bool>
    {
        public Task<bool> HandleAsync(PrintSomethingRequest request)
        {
            Console.WriteLine($"{request.Text} printed.");
            return Task.FromResult(true);
        }
    }
}
