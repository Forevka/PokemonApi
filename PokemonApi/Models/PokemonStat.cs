using System;
using System.Collections.Generic;

namespace PokemonApi
{
    public partial class PokemonStat
    {
        public int PokemonId { get; set; }
        public int StatId { get; set; }
        public int? Value { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Stat Stat { get; set; }
    }
}
