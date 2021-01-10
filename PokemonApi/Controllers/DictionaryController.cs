using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PokemonApi.Queries;

namespace PokemonApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {

        private readonly IMediator _mediator;

        public DictionaryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("types")]
        public async Task<IList<Type>> GetTypes()
        {
            var query = new GetTypesQuery();
            var result = await _mediator.Send(query);
            return result;
        }

        [HttpGet("stats")]
        public async Task<IList<Stat>> GetStats()
        {
            var query = new GetStatsQuery();
            var result = await _mediator.Send(query);
            return result;
        }
    }
}