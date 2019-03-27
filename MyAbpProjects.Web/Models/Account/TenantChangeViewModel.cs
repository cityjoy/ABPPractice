using Abp.AutoMapper;
using MyAbpProjects.Sessions.Dto;

namespace MyAbpProjects.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}