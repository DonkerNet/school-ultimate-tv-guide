using System;
using System.Collections.Generic;

namespace UltimateTvGuide.Web.Models
{
    public class GuideIndexViewModel
    {
        public string Country { get; set; }
        public List<Channel> Channels { get; set; }
        public bool HasChannels => Channels != null && Channels.Count > 0;

        public class Channel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Uri LogoUri { get; set; }
            public List<Show> Shows { get; set; }
            public bool HasShows => Shows != null && Shows.Count > 0;
        }

        public class Show
        {
            public string Name { get; set; }
            public DateTimeOffset StartTime { get; set; }
            public DateTimeOffset EndTime { get; set; }
            public float ImdbRating { get; set; }
            public string Plot { get; set; }
            public Uri LogoUri { get; set; }
        }
    }
}