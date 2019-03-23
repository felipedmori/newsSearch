using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace newsSearcher.Domain.Interfaces.Repositories
{
    public interface IGoogleNewsRepository
    {

        Task<List<Domain.Entities.News>> List(string keyWord, int limit, string industry);

      
    }
}
