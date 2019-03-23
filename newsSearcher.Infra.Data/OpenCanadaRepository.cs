using newsSearcher.Domain.Entities;
using newsSearcher.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Globalization;
using Newtonsoft.Json;

namespace newsSearcher.Infra.Data
{
    public class OpenCanadaRepository : IOpenCanadaRepository
    {

        private readonly Config _config;

        public OpenCanadaRepository(Config config)
        {
            _config = config;
        }

        public async Task<List<News>> List(string keyWord, int limit, string industry)
        {

            List<News> result = new List<News>();

            try
            {
                var client = new RestClient(_config.openCanadaUrl);

                var request = new RestRequest(Method.GET);
                request.AddQueryParameter("q", keyWord);


                IRestResponse response = client.Execute(request);
                var content = response.Content;

                var jObject = JsonConvert.DeserializeObject<OpenCanadaJsonParse>(response.Content);
                int newsCount = 0;

                foreach (var article in jObject.result.results)
                {

                    foreach (var jsonresources in article.resources)
                    {

                        if (jsonresources.format == "HTML")
                        {
                            newsCount++;

                            if (newsCount <= limit)
                            {

                                result.Add(new News
                                {
                                    Industry = industry,
                                    Source = "Open Canada",
                                    Title = jsonresources.name,
                                    Url = jsonresources.url,
                                    KeyWord = keyWord,
                                    date = jsonresources.created
                                });
                            }
                            else
                            {
                                continue;
                            }
                        }
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
