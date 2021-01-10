using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApi.Queries
{
    public class GetStatsQuery : IRequest<IList<Stat>>
    {
    }
}
