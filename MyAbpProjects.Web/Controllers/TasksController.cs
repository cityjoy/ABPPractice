using Abp.Web.Mvc.Controllers;
using MyAbpProjects.Tasks;
using MyAbpProjects.Tasks.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using X.PagedList;
namespace MyAbpProjects.Web.Controllers
{
    public class TasksController : AbpController
    {
        private readonly ITaskAppService _taskAppService;
            public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }
        // GET: Tasks
        public ActionResult Index(int? page)
        {
            //每页行数
            var pageSize = 5;
            var pageNumber = page ?? 1; //第几页

            var filter = new GetTasksInput
            {
                SkipCount = (pageNumber - 1) * pageSize, //忽略个数
                MaxResultCount = pageSize
            };
            var result = _taskAppService.GetPagedTasks(filter);

            //已经在应用服务层手动完成了分页逻辑，所以需手动构造分页结果
            var onePageOfTasks = new StaticPagedList<TaskDto>(result.Items, pageNumber, pageSize, result.TotalCount);
            //将分页结果放入ViewBag供View使用
            //ViewBag.OnePageOfTasks = onePageOfTasks;
            var list = _taskAppService.GetAllTasks();
            //_taskAppService.DeleteTask(1);
            return View(onePageOfTasks);
        }
    }
}