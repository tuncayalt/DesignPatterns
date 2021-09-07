using System.Threading.Tasks;

namespace DesignPatternsLibrary.Mediators
{
    public interface IMediator
    {
        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request);
    }
}
