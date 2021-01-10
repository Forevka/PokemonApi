using System;
using System.Collections.Generic;

namespace PokemonApi
{
    public partial class Stat
    {
        public Stat()
        {
            PokemonStat = new HashSet<PokemonStat>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PokemonStat> PokemonStat { get; set; }
    }
}
