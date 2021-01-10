using MediatR;
using PokemonApi.Queries;
using PokemonApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PokemonApi.Handlers
{
    public class GetPokemonsHandler : IRequestHandler<GetPokemonsQuery, IList<Pokemon>>
    {
        private readonly IPokemonRepository _pokemonRepository;

        public GetPokemonsHandler(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<IList<Pokemon>> Handle(GetPokemonsQuery request, CancellationToken cancellationToken)
        {
            return await _pokemonRepository.GetPokemons();
        }
    }
}
