using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpProjects.MultiTenancy.Dto;

namespace MyAbpProjects.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
