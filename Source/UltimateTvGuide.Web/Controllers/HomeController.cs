using System.Web.Mvc;

namespace UltimateTvGuide.Web.Controllers
{
    [RoutePrefix("")]
    [Route("{action=Index}")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}