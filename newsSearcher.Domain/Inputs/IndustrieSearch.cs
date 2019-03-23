using System;
using System.Collections.Generic;
using System.Text;

namespace newsSearcher.Domain.Inputs
{
    public class IndustrySearch
    {   
            public string Name { get; set; }
            public int Limit { get; set; }
            public List<string> SearchKeyWords { get; set; }
        
    }
}
