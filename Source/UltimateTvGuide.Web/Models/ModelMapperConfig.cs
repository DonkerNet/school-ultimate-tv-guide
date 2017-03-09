using System;
using System.Collections.Generic;
using AutoMapper;
using UltimateTvGuide.Domain.Entities;

namespace UltimateTvGuide.Web.Models
{
    internal static class ModelMapperConfig
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
                c.CreateMap<TvGuide, GuideIndexViewModel>()
                    .AfterMap(AfterGuideMap);

                c.CreateMap<TvChannel, GuideIndexViewModel.Channel>()
                .AfterMap(AfterChannelMap);

                c.CreateMap<TvShow, GuideIndexViewModel.Show>();
            });
        }

        private static void AfterChannelMap(TvChannel source, GuideIndexViewModel.Channel destination)
        {
            // Sort shows by start time
            destination.Shows.Sort((f, s) => f.StartTime.CompareTo(s.StartTime));
        }

        private static void AfterGuideMap(TvGuide source, GuideIndexViewModel destination)
        {
            // Remove channels without shows
            destination.Channels.RemoveAll(c => !c.HasShows);

            // Sort channels by name
            destination.Channels.Sort((f, s) => string.Compare(f.Name, s.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}