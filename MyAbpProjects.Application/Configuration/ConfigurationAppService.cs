using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyAbpProjects.Configuration.Dto;

namespace MyAbpProjects.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyAbpProjectsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
