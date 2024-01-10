using Microsoft.AspNetCore.Mvc;
using TaskWebAPI.Application.Services.Tasks;

namespace TaskWebAPI.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var tasks = _taskService.GetAll();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var task = _taskService.GetById(id);
            if (task == null)
                return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] Domain.Models.Task task)
        {
            _taskService.Add(task);
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(Guid id, [FromBody] Domain.Models.Task newTask)
        {
            var task = _taskService.GetById(id);
            if (task == null)
                return NotFound();

            newTask.Id = id;
            _taskService.Update(newTask);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveTask(Guid id)
        {
            var task = _taskService.GetById(id);
            if (task == null)
                return NotFound();

            _taskService.Remove(id);
            return NoContent();
        }
    }
}
