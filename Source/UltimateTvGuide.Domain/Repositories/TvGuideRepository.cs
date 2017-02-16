using UltimateTvGuide.Service.TvGuide;
using TvGuide = UltimateTvGuide.Domain.Entities.TvGuide;

namespace UltimateTvGuide.Domain.Repositories
{
    public interface ITvGuideRepository
    {
        TvGuide GetByCountry(string country);
    }

    public class TvGuideRepository : RepositoryBase, ITvGuideRepository
    {
        private readonly TvGuideClient _tvGuideClient;

        public TvGuideRepository()
        {
            _tvGuideClient = new TvGuideClient();
        }

        public TvGuide GetByCountry(string country)
        {
            GuideRequestIn request = new GuideRequestIn { Country = country };
            Guide guide = _tvGuideClient.GetGuide(request);
            TvGuide tvGuide = Mapper.Map<TvGuide>(guide);
            return tvGuide;
        }
    }
}