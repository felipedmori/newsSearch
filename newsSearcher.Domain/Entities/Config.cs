using System;
using System.Collections.Generic;
using System.Text;

namespace newsSearcher.Domain.Entities
{
    public  class Config
    {

        public  readonly string googleNewsUrl = "https://newsapi.org/v2/everything";
        public  readonly string googleNewsApiKey = "02aa376a02064ef8ba41f568c395547b";

        public readonly string openCanadaUrl = "https://open.canada.ca/data/en/api/3/action/package_search"; 

    }
}
