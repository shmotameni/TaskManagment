using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskService.Models;

namespace TaskService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly List<TaskItem> _tasks = new()
        {
            new TaskItem
            {
                Id = 1,
                Title = "Learn Microservices",
                Description = "Understand microservices architecture",
                IsCompleted = false
            },
            new TaskItem
            {
                Id = 2,
                Title = "Learn ASP.NET Core",
                Description = "Build a Web API",
                IsCompleted = true
            }
        };

        [HttpGet]
        public ActionResult<List<TaskItem>> GetAllTasks()
        {
            return Ok(_tasks);
        }
    }
}
