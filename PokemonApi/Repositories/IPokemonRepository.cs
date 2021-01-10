using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApi.Repositories
{
    public interface IPokemonRepository
    {
        Task<Pokemon> GetPokemonById(int idPokemon);
        Task<IList<Pokemon>> GetPokemons();
        Task<IList<Type>> GetTypes();
        Task<IList<Stat>> GetStats();

    }
}
