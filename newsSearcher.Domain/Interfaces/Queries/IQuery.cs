using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace newsSearcher.Domain.Interfaces.Commands
{
    public interface IQuery<T,T1>
    {
        Task<T1> ExecuteQuery(T input, string additionalParam);
    }
}
