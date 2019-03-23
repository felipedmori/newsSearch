using newsSearcher.Domain.Entities;
using newsSearcher.Domain.Inputs;
using newsSearcher.Domain.Interfaces.Commands;
using newsSearcher.Domain.Interfaces.Repositories;
using newsSearcher.Domain.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace newsSearcher.Domain.Queries
{


    public class QueryNews : IQuery<NewsSearchInput, List<NewsSearchResult>>
    {

        private readonly IGoogleNewsRepository _googleNewsRepository;
        private readonly IOpenCanadaRepository _openCanadaRepository;

        public QueryNews(IGoogleNewsRepository googleNewsRepository, IOpenCanadaRepository openCanadaRepository)
        {
            _googleNewsRepository = googleNewsRepository;
            _openCanadaRepository = openCanadaRepository;
        }

        public async Task<List<NewsSearchResult>> ExecuteQuery(NewsSearchInput input, string source)
        {

            List<NewsSearchResult> result = new List<NewsSearchResult>();

            foreach (IndustrySearch ind in input.industries)
            {
                List<News> IndustryNews = new List<News>();

                foreach (string keyWord in ind.SearchKeyWords)
                {
                    if (source == "google" || source == "all")
                    {
                        var searchResultGoogle = await _googleNewsRepository.List(keyWord, ind.Limit, ind.Name);
                        IndustryNews.AddRange(searchResultGoogle);
                    }

                    if (source == "openCanada" || source == "all")
                    {
                        var searchResultOpenCanada = await _openCanadaRepository.List(keyWord, ind.Limit, ind.Name);
                        IndustryNews.AddRange(searchResultOpenCanada);
                    }
                }

                result.Add(new NewsSearchResult { Industry = ind.Name, News = IndustryNews });

            }
   
            return result;
        }
    }
}
