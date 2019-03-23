using System;
using System.Collections.Generic;
using System.Text;

namespace newsSearcher.Domain.Entities
{
    public class News
    {
        public string Industry { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Source { get; set; }
        public string KeyWord { get; set; }
        public DateTime date { get; set; }


    }
}
