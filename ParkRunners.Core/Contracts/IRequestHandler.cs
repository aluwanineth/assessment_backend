using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkRunners.Core.Contracts
{
    public interface IRequestHandler<in TRequest, out TResponse> where TRequest : IRequest<TResponse>
    {
        Task<bool> HandleAsync(TRequest message, IOutputPort<TResponse> outputPort);
    }
}
