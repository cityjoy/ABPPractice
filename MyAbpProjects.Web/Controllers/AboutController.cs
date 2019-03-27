using System.Web.Mvc;

namespace MyAbpProjects.Web.Controllers
{
    public class AboutController : MyAbpProjectsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}