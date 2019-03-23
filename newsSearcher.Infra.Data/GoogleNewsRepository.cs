using newsSearcher.Domain.Entities;
using newsSearcher.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Globalization;

namespace newsSearcher.Infra.Data
{
    public class GoogleNewsRepository : IGoogleNewsRepository
    {

        private readonly Config _config;

        public GoogleNewsRepository(Config config)
        {
            _config = config;
        }

        public async Task<List<News>> List(string keyWord, int limit, string industry )
        {

            List<News> result = new List<News>();
            try { 
            var client = new RestClient(_config.googleNewsUrl);
         
            var request = new RestRequest(Method.GET);
            request.AddQueryParameter("q", keyWord); 
            request.AddQueryParameter("apiKey", _config.googleNewsApiKey); 
      
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var jObject = Newtonsoft.Json.Linq.JObject.Parse(response.Content);
            int newsCount = 0;
            foreach( var article in  jObject["articles"])
            {
                newsCount++;

                if (newsCount <= limit)
                {

                    result.Add(new News
                    {
                        Industry = industry,
                        Source = "Google News",
                        Title = article["title"].ToString(),
                        Url = article["url"].ToString(),
                        KeyWord = keyWord

                    ,
                        date = DateTime.Parse(article["publishedAt"].ToString())
                    });
                }
                else
                {
                    continue;
                }

            }
            }
            catch (Exception ex)
            {
                //Todo: Write some Log or return an error message to consumer
            }


            return result;

        }
    }
}
