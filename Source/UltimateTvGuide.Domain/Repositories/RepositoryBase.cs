using AutoMapper;
using UltimateTvGuide.Domain.Entities;

namespace UltimateTvGuide.Domain.Repositories
{
    public abstract class RepositoryBase
    {
        protected IMapper Mapper => EntityMapperConfig.GetMapper();
    }
}