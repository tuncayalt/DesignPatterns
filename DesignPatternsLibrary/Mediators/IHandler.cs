using System.Threading.Tasks;

namespace DesignPatternsLibrary.Mediators
{
    public interface IHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        Task<TResponse> HandleAsync(TRequest request);
    }
}
