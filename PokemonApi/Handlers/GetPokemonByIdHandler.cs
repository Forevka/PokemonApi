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
    public class GetPokemonByIdHandler : IRequestHandler<GetPokemonByIdQuery, Pokemon>
    {
        private readonly IPokemonRepository _pokemonRepository;

        public GetPokemonByIdHandler(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<Pokemon> Handle(GetPokemonByIdQuery request, CancellationToken cancellationToken)
        {
            return await _pokemonRepository.GetPokemonById(request.PokemonId);
        }
    }
}
