using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyAbpProjects.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyAbpProjectsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}