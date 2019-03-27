using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAbpProjects.Tasks;

namespace MyAbpProjects.IRepositories
{

    /// <summary>
    /// 自定义仓储示例
    /// </summary>
    public interface IBackendTaskRepository : IRepository<Task>
    {
        /// <summary>
        /// 根据时间段获取分配了哪些任务
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        List<Task> GetTaskByDateRange(DateTime start,DateTime end);
    }

}
