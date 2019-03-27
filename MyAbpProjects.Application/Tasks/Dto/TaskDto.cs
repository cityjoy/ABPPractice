using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAbpProjects.Tasks;

namespace MyAbpProjects.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskDto : EntityDto
    {

        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

        //This method is just used by the Console Application to list tasks
        public override string ToString()
        {
            return string.Format("[Task Id={0},Title={1}, Description={2},CreationTime={3}", Id, Title, Description, CreationTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}

