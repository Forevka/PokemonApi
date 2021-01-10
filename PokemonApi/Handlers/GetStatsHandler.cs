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
    public class GetStatsHandler : IRequestHandler<GetStatsQuery, IList<Stat>>
    {
        private readonly IPokemonRepository _pokemonRepository;

        public GetStatsHandler(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<IList<Stat>> Handle(GetStatsQuery request, CancellationToken cancellationToken)
        {
            return await _pokemonRepository.GetStats();
        }
    }
}
