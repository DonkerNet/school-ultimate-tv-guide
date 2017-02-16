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
                c.CreateMap<TvGuide, GuideIndexViewModel>();
                c.CreateMap<TvChannel, GuideIndexViewModel.Channel>();
                c.CreateMap<TvShow, GuideIndexViewModel.Show>();
            });
        }
    }
}