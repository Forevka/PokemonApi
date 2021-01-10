using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApi.Queries
{
    public class GetPokemonByIdQuery : IRequest<Pokemon>
    {
        public int PokemonId { get; }

        public GetPokemonByIdQuery(int pokemonId)
        {
            PokemonId = pokemonId;
        }
    }
}
