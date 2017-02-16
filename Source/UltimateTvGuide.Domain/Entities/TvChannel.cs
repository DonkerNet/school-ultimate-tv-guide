using System;
using System.Collections.Generic;

namespace UltimateTvGuide.Domain.Entities
{
    public class TvChannel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri LogoUri { get; set; }
        public IList<TvShow> Shows { get; set; }
    }
}