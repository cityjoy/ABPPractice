using System.Reflection;
using Abp.Modules;
using Abp.Web.Mvc;
using MyAbpProjects.PlugIns.PlugInZero.Authorization;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyAbpProjects.PlugIns.PlugInZero
{
    //插件计划提供一个MvcController，所以依赖AbpWebMvcModule模块
    [DependsOn(typeof(AbpWebMvcModule))] 
    public class PlugInZeroModule : AbpModule
    {
        public override void PreInitialize()
        {
            //插件配置(直接从当前执行的程序集的config文件读取数据库连接串)
            //var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            //string connectStr = config.ConnectionStrings.ConnectionStrings["PlugInZeroDB"].ConnectionString;
            //注册DbContext,构建时使用指定参数
            //IocManager.IocContainer.Register(
            //    Component.For<PlugInZeroDbContext>()
            //    .DependsOn(
            //        Dependency.OnValue(
            //            "connectionString",connectStr)));

            //注册权限
            Configuration.Authorization.Providers.Add<PlugInZeroAuthorizationProvider>();
            //注册菜单
            Configuration.Navigation.Providers.Add<Navigation.PlugInZeroNavigationProvider>();
            //注册路由
            RouteTable.Routes.MapRoute(
                "Plugins",
                url: "PlugIns/{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
