using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApi.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDbContext _pokemonDbContext;
        public PokemonRepository(PokemonDbContext pokemonDbContext)
        {
            _pokemonDbContext = pokemonDbContext;
        }

        public async Task<Pokemon> GetPokemonById(int idPokemon)
        {
            return await _pokemonDbContext.Pokemon.Include(p => p.PokemonStat)
                .Include(p => p.PokemonType)
                .Where(i=>i.Id == idPokemon)
                .FirstOrDefaultAsync();                               
        }

        public async Task<IList<Pokemon>> GetPokemons()
        {
            return await _pokemonDbContext.Pokemon.Include(p => p.PokemonStat)
                .Include(p => p.PokemonType).ToListAsync();
        }

        public async Task<IList<Stat>> GetStats()
        {
            return await _pokemonDbContext.Stat.ToListAsync();
        }

        public async Task<IList<Type>> GetTypes()
        {
            return await _pokemonDbContext.Type.ToListAsync();
        }
    }
}
