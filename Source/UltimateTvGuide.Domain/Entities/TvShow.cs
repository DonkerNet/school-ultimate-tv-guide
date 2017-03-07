using System;

namespace UltimateTvGuide.Domain.Entities
{
    public class TvShow
    {
        public string Name { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public int ImdbRating { get; set; }
        public string Plot { get; set; }
        public Uri LogoUri { get; set; }
    }
}