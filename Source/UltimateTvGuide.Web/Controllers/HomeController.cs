using System.Web.Mvc;

namespace UltimateTvGuide.Web.Controllers
{
    [RoutePrefix("")]
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