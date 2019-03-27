using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using MyAbpProjects.Tasks.Dto;
using Abp.Extensions;
using MyAbpProjects.IRepositories;
using Abp.Authorization;
using MyAbpProjects.Authorization;

namespace MyAbpProjects.Tasks
{
    public class TaskAppService : MyAbpProjectsAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;
        private readonly IBackendTaskRepository _backendTaskRepository;

        public TaskAppService(IRepository<Task> taskRepository, IBackendTaskRepository backendTaskRepository)
        {
            _taskRepository = taskRepository;
            _backendTaskRepository = backendTaskRepository;
        }
        [AbpAuthorize("Pages.Tasks.Delete")]
        public void DeleteTask(int taskId)
        {
            var model = _taskRepository.FirstOrDefault(taskId);
            if (null != model)
            {
                _taskRepository.Delete(taskId);
            }
        }
        [AbpAuthorize("Pages.Tasks")]
        public IList<TaskDto> GetAllTasks()
        {
            // 转换为DTO对象
        
            var tasks = _taskRepository.GetAll();
            //var result = tasks
            //.Select(t => new TaskDto
            //{
            //     Id=t.Id,
            //      Title=t.Title,
            //       CreationTime=t.CreationTime,
            //        Description=t.Description
            //}).ToList();
            //tasks = _backendTaskRepository.GetTaskByDateRange(DateTime.Now.AddDays(-3), DateTime.Now.AddDays(1));
            var result = ObjectMapper.Map<List<TaskDto>>(tasks);
            return result;
        }

        public PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input)
        {
            //初步过滤
            var query = _taskRepository.GetAll()
               .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
               .WhereIf(!input.Filter.IsNullOrEmpty(), t => t.Title.Contains(input.Filter));

            //排序
            query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(t=>t.State) : query.OrderByDescending(t => t.CreationTime);

            //获取总数
            var tasksCount = query.Count();
            //默认的分页方式
            //var taskList = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();

            //ABP提供了扩展方法PageBy分页方式
            var taskList = query.PageBy(input).ToList();

            return new PagedResultDto<TaskDto>(tasksCount, ObjectMapper.Map<List < TaskDto>>(taskList));
        }
    }
}
