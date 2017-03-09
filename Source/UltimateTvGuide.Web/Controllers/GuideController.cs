using System.Web.Mvc;
using AutoMapper;
using UltimateTvGuide.Domain.Entities;
using UltimateTvGuide.Domain.Repositories;
using UltimateTvGuide.Web.Models;

namespace UltimateTvGuide.Web.Controllers
{
    [RoutePrefix("guide")]
    public class GuideController : Controller
    {
        private readonly ITvGuideRepository _tvGuideRepository;
        private readonly IMapper _modelMapper;

        public GuideController()
        {
            _tvGuideRepository = new TvGuideRepository();
            _modelMapper = ModelMapperConfig.GetMapper();
        }

        [HttpGet]
        [Route("{country}", Order = 1)]
        [Route("", Order = 2)]
        public ActionResult Index(string country = null)
        {
            TvGuide tvGuide = _tvGuideRepository.GetByCountry(country);
            GuideIndexViewModel model = _modelMapper.Map<GuideIndexViewModel>(tvGuide);
            return View(model);
        }
    }
}