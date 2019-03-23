using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace newsSearcher.Domain.Interfaces.Commands
{
    public interface ICommand<T,T1>
    {
        Task<T1> Execute(T input);
    }
}
