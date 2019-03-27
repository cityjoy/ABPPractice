using Abp.Application.Services.Dto;
using MyAbpProjects.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProjects.Tasks.Dto
{
    public class GetTasksInput : PagedSortedAndFilteredInputDto
    {
        public TaskState? State { get; set; }
    }
}
