using System;
using System.IO;
using System.Threading;
using System.Web;
using Abp.Castle.Logging.Log4Net;
using Abp.Extensions;
using Abp.PlugIns;
using Abp.Web;
using Abp.WebApi.Validation;
using Castle.Facilities.Logging;
using MyAbpProjects.Web;

[assembly: PreApplicationStartMethod(typeof(PreStarter), "Start")]
namespace MyAbpProjects.Web
{
    public static class PreStarter
    {
        public static void Start()
        {
            //...
            var plugInsRootPath = $"{AppDomain.CurrentDomain.BaseDirectory.EnsureEndsWith('\\')}Plugins";

            if (Directory.Exists(plugInsRootPath))
            {
                MvcApplication.AbpBootstrapper.PlugInSources.AddFolder(plugInsRootPath, SearchOption.AllDirectories);
                MvcApplication.AbpBootstrapper.PlugInSources.AddToBuildManager();
            }
        }
    }
    public class MvcApplication : AbpWebApplication<MyAbpProjectsWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            
            base.Application_Start(sender, e);
        }
    }
}

