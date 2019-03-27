using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpProjects.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProjects.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        IList<TaskDto> GetAllTasks();
        PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input);
        void DeleteTask(int taskId);
    }
 
}
