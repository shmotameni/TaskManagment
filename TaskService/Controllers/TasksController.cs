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

        [HttpGet("{id}")]
        public ActionResult<TaskItem> GetTaskById(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskItem> CreateTask([FromBody] TaskItem task)
        {
            task.Id = _tasks.Count == 0 ? 1 : _tasks.Max(t => t.Id) + 1;

            _tasks.Add(task);

            return CreatedAtAction(
                nameof(GetTaskById),
                new { id = task.Id },
                task
            );
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskItem updatedTask)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == id);

            if (existingTask == null)
            {
                return NotFound();
            }

            existingTask.Title = updatedTask.Title;
            existingTask.Description = updatedTask.Description;
            existingTask.IsCompleted = updatedTask.IsCompleted;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound();
            }

            _tasks.Remove(task);

            return NoContent();
        }
    }
}
