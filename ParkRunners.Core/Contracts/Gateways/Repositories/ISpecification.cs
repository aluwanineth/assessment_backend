using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ParkRunners.Core.Contracts.Gateways.Repositories
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}

