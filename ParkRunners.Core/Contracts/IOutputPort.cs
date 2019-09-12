using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Contracts
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
