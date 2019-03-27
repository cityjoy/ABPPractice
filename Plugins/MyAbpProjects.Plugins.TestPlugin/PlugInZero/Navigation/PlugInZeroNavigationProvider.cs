using System.Linq;
using Abp.Application.Navigation;
using Abp.Localization;

namespace MyAbpProjects.PlugIns.PlugInZero.Navigation
{
    public class PlugInZeroNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            var hostMenu = context.Manager.MainMenu;
            var plugInRoot = hostMenu.Items.FirstOrDefault(i => i.Name == "PlugIns");
            if (plugInRoot == null)
            {
                plugInRoot = new MenuItemDefinition(
                    "PlugIns",
                    new FixedLocalizableString("插件功能"),
                    url: "PlugIns/PlugInZero",
                    icon: "menu"
                    //由于Demo目前无法编辑权限，暂时不启用菜单项的权限依赖
                    //requiredPermissionName: PlugInZeroConsts.PermissionNames.PlugIns
                    );

                hostMenu.AddItem(plugInRoot);
            }
            plugInRoot.AddItem(
                new MenuItemDefinition(
                    "PlugInZero",
                    new FixedLocalizableString("PlugInZero(插件)"),
                    url: "PlugIns/PlugInZero/Hello",//指定Controller的路由
                    icon: ""
                    //target: "_blank"//新开一个窗口
                    //requiredPermissionName: PlugInZeroConsts.PermissionNames.PlugInZero
                    ));
        }
    }
}
