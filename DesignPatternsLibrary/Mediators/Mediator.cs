using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Mediators
{
    public class Mediator : IMediator
    {
        private readonly Func<Type, object> _serviceResolver;
        private readonly ConcurrentDictionary<Type, Type> _handlerDetails;

        public Mediator(Func<Type, object> serviceResolver, IDictionary<Type, Type> handlerDetails)
        {
            _serviceResolver = serviceResolver;
            _handlerDetails = new ConcurrentDictionary<Type, Type>(handlerDetails);
        }

        public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            var requestType = request.GetType();
            if (!_handlerDetails.ContainsKey(requestType))
            {
                throw new Exception($"No handler to handle request of type: {requestType.Name}");
            }

            var requestHandlerType = _handlerDetails[requestType];

            var handlerObject = _serviceResolver(requestHandlerType);
            return await (Task<TResponse>)handlerObject.GetType().GetMethod("HandleAsync")
                .Invoke(handlerObject, new[] { request });
        }
    }
}
