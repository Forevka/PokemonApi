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
    public class GetTypesHandler : IRequestHandler<GetTypesQuery, IList<Type>>
    {
        private readonly IPokemonRepository _pokemonRepository;

        public GetTypesHandler(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<IList<Type>> Handle(GetTypesQuery request, CancellationToken cancellationToken)
        {
            return await _pokemonRepository.GetTypes();
        }
    }
}
