using System;
using System.Collections.Generic;
using System.Linq;
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

                c.CreateMap<Guide, TvGuide>().ConvertUsing(MapTvGuide);
            });
        }

        private static TvGuide MapTvGuide(Guide source, TvGuide destination, ResolutionContext context)
        {
            // Group channels with the same ID into a single group

            Dictionary<int, TvChannel> tvChannelDict = new Dictionary<int, TvChannel>();

            foreach (GuideChannel channel in source.Channel)
            {
                TvChannel newTvChannel = context.Mapper.Map<TvChannel>(channel);

                TvChannel existingTvChannel;
                if (tvChannelDict.TryGetValue(newTvChannel.Id, out existingTvChannel))
                {
                    foreach (TvShow tvShow in newTvChannel.Shows)
                        existingTvChannel.Shows.Add(tvShow);
                }
                else
                {
                    tvChannelDict.Add(newTvChannel.Id, newTvChannel);
                }
            }

            destination = new TvGuide
            {
                LoadDate = TryParseDateTimeOffset(source.LoadDate),
                Country = source.Country,
                Channels = tvChannelDict.Values.OrderBy(c => c.Name).ToList()
            };

            return destination;
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