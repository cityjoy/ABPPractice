using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpProjects.Authorization.Accounts.Dto;

namespace MyAbpProjects.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
