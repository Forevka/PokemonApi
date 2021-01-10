using System;
using System.Collections.Generic;

namespace PokemonApi
{
    public partial class Type
    {
        public Type()
        {
            PokemonType = new HashSet<PokemonType>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PokemonType> PokemonType { get; set; }
    }
}
