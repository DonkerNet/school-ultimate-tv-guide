﻿using System;
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
                    .ForMember(d => d.StartTime, m => m.ResolveUsing(s => ParseTimeStringToFutureDateTimeOffset(s.StartTime)))
                    .ForMember(d => d.EndTime, m => m.ResolveUsing(s => ParseTimeStringToFutureDateTimeOffset(s.EndTime)))
                    .ForMember(d => d.ImdbRating, m => m.ResolveUsing(s => float.Parse(s.IMDBRating, NumberFormatInfo.InvariantInfo)))
                    .ForMember(d => d.LogoUri, m => m.ResolveUsing(s => !string.IsNullOrEmpty(s.Logo) ? new Uri(s.Logo, UriKind.Absolute) : null));

                c.CreateMap<GuideChannel, TvChannel>()
                    .ForMember(d => d.Id, m => m.ResolveUsing(s => int.Parse(s.ChannelId)))
                    .ForMember(d => d.Name, m => m.ResolveUsing(s => s.ChannelName))
                    .ForMember(d => d.Shows, m => m.ResolveUsing(s => s.Show))
                    .ForMember(d => d.LogoUri, m => m.ResolveUsing(s => !string.IsNullOrEmpty(s.Logo) ? new Uri(s.Logo, UriKind.Absolute) : null));

                c.CreateMap<Guide, TvGuide>()
                    .ForMember(d => d.LoadDate, m => m.ResolveUsing(s => DateTimeOffset.ParseExact(s.LoadDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)))
                    .ForMember(d => d.Channels, m => m.ResolveUsing(s => s.Channel));
            });
        }

        private static DateTimeOffset ParseTimeStringToFutureDateTimeOffset(string timeString)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            TimeSpan timeSpan = TimeSpan.ParseExact(timeString, "g", CultureInfo.InvariantCulture);
            DateTimeOffset result = new DateTimeOffset(now.Year, now.Month, now.Day, timeSpan.Hours, timeSpan.Minutes, now.Second, now.Offset);
            if (result < now)
                result = result.AddDays(1);
            return result;
        }
    }
}