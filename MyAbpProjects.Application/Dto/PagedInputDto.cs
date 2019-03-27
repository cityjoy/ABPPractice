using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpProjects.Dto
{
    /// <summary>
    /// 支持分页的InputDto
    /// </summary>
    public class PagedInputDto : IPagedResultRequest
    {
        [Range(1, 50)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public PagedInputDto()
        {
            MaxResultCount = 10;
        }
    }
}
