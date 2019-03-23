using newsSearcher.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace newsSearcher.Domain.Results
{
   public class NewsSearchResult
    {
        public string Industry { get; set; }
        public List<News> News { get; set; }  
    }
}
