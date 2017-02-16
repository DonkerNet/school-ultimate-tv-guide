using System;
using System.Collections.Generic;

namespace UltimateTvGuide.Domain.Entities
{
    public class TvGuide
    {
        public string Country { get; set; }
        public DateTimeOffset LoadDate { get; set; }
        public IList<TvChannel> Channels { get; set; }
    }
}