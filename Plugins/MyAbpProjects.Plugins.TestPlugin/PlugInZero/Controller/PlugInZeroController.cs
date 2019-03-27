using System;
using System.Configuration;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;

namespace MyAbpProjects.PlugIns.PlugInZero.Controller
{
    //[Route("PlugIns/{controller]/[action]")]
    public class PlugInZeroController : AbpController
    {
        public PlugInZeroController()
        {
            LocalizationSourceName = "Abp";
        }

        public Task<string> Hello()
        {
            return Task.FromResult($"hello at {DateTime.Now}");
        }
    }
}
