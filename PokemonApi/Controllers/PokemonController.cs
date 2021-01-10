using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PokemonApi.Queries;

namespace PokemonApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PokemonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{pokemonId}")]
        public async Task<ActionResult> GetPokemonById(int pokemonId)
        {
            var query = new GetPokemonByIdQuery(pokemonId);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("pokemons")]
        public async Task<IList<Pokemon>> GetPokemons()
        {
            var query = new GetPokemonsQuery();
            var result = await _mediator.Send(query);
            return result;
        }
    }
}
