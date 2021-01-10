using System;
using System.Collections.Generic;

namespace PokemonApi
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            PokemonStat = new HashSet<PokemonStat>();
            PokemonType = new HashSet<PokemonType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }

        public virtual ICollection<PokemonStat> PokemonStat { get; set; }
        public virtual ICollection<PokemonType> PokemonType { get; set; }
    }
}
