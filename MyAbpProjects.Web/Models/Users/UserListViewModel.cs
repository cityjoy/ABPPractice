using System.Collections.Generic;
using MyAbpProjects.Roles.Dto;
using MyAbpProjects.Users.Dto;

namespace MyAbpProjects.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}