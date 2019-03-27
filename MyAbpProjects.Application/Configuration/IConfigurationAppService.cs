using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpProjects.Configuration.Dto;

namespace MyAbpProjects.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}