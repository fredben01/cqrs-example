using Banking.Cqrs.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Cqrs.Core.Handlers
{
    public interface EventSourcingHandler<T>
    {
        Task Save(AggregateRoot aggregate);
        Task<T> GetById(string id);
    }
}
