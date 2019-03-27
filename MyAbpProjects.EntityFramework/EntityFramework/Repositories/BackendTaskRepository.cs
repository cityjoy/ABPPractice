using Abp.EntityFramework;
using MyAbpProjects.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyAbpProjects.Tasks;

namespace MyAbpProjects.EntityFramework.Repositories
{
     
    /// <summary>
    /// 自定义仓储示例
    /// </summary>
    public class BackendTaskRepository: MyAbpProjectsRepositoryBase<Task>, IBackendTaskRepository
    {
        public BackendTaskRepository(IDbContextProvider<MyAbpProjectsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        /// <summary>
        /// 根据时间段获取分配了哪些任务
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<Task> GetTaskByDateRange(DateTime start, DateTime end)
        {
            var query = GetAllList(m=>m.CreationTime>start&&m.CreationTime<end);
            return query.ToList();
        }

        
    }
}
 
