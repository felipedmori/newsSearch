using System;
using System.Threading.Tasks;
using newsSearcher.Domain.Inputs;
using newsSearcher.Domain.Interfaces.Commands;

using newsSearcher.Domain.Results;
using Microsoft.AspNetCore.Mvc;
using newsSearcher.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using newsSearcher.Domain.Entities;
using newsSearcher.Domain.Queries;

namespace newsSearcher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly QueryNews _queryNews;

        public NewsController(QueryNews queryNews)
        {
            _queryNews = queryNews;
        }

        [HttpPost]
        public async Task<ActionResult<List<NewsSearchResult>>> Post([FromBody] NewsSearchInput SearchParams)
        {
            var result = await _queryNews.ExecuteQuery(SearchParams, "all");
            return result;
        }

        [HttpPost("GetGoogleNews")]
        public async Task<ActionResult<List<NewsSearchResult>>> PostGN([FromBody] NewsSearchInput SearchParams)
        {
            var result = await _queryNews.ExecuteQuery(SearchParams, "google");
            return result;
        }

        [HttpPost("GetOpenCanada") ]
        public async Task<ActionResult<List<NewsSearchResult>>> PostOC([FromBody] NewsSearchInput SearchParams)
        {
            var result = await _queryNews.ExecuteQuery(SearchParams, "openCanada");
            return result;
        }


        
   

    }
}
