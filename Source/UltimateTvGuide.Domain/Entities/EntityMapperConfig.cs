using System;
using System.Globalization;
using AutoMapper;
using UltimateTvGuide.Service.TvGuide;

namespace UltimateTvGuide.Domain.Entities
{
    internal static class EntityMapperConfig
    {
        private static IMapper _mapper;

        public static IMapper GetMapper()
        {
            if (_mapper == null)
            {
                IConfigurationProvider config = CreateConfig();
                _mapper = config.CreateMapper();
            }

            return _mapper;
        }

        private static IConfigurationProvider CreateConfig()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<GuideChannelShow, TvShow>()
                    .ForMember(d => d.StartTime, m => m.ResolveUsing(s => TryParseDateTimeOffset(s.StartTime)))
                    .ForMember(d => d.EndTime, m => m.ResolveUsing(s => TryParseDateTimeOffset(s.EndTime)))
                    .ForMember(d => d.ImdbRating, m => m.ResolveUsing(s => TryParseRating(s.IMDBRating)))
                    .ForMember(d => d.LogoUri, m => m.ResolveUsing(s => TryParseUri(s.Logo)));
                
                c.CreateMap<GuideChannel, TvChannel>()
                    .ForMember(d => d.Id, m => m.ResolveUsing(s => int.Parse(s.ChannelId)))
                    .ForMember(d => d.Name, m => m.ResolveUsing(s => s.ChannelName))
                    .ForMember(d => d.LogoUri, m => m.ResolveUsing(s => TryParseUri(s.Logo)))
                    .ForMember(d => d.Shows, m => m.ResolveUsing(s => s.Show));

                c.CreateMap<Guide, TvGuide>()
                    .ForMember(d => d.LoadDate, m => m.ResolveUsing(s => TryParseDateTimeOffset(s.LoadDate)))
                    .ForMember(d => d.Channels, m => m.ResolveUsing(s => s.Channel));
            });
        }

        #region Helper methods

        private static DateTimeOffset TryParseDateTimeOffset(string input)
        {
            DateTimeOffset result;
            DateTimeOffset.TryParse(input, out result);
            return result;
        }

        private static int TryParseRating(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int slashIndex = input.IndexOf('/');

            if (slashIndex <= 0)
                return 0;

            string ratingString = input.Substring(0, slashIndex);

            int rating;
            int.TryParse(ratingString, out rating);
            return rating;
        }

        private static Uri TryParseUri(string input)
        {
            Uri result;
            Uri.TryCreate(input, UriKind.Absolute, out result);
            return result;
        }

        #endregion
    }
}