using TaskWebAPI.Infrastructure.Repositories.Tasks;

namespace TaskWebAPI.Application.Services.Tasks
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<Domain.Models.Task> GetAll()
        {
            return _taskRepository.GetAll();
        }

        public Domain.Models.Task GetById(Guid id)
        {
            return _taskRepository.GetById(id);
        }

        public void Add(Domain.Models.Task task)
        {
            task.Id = Guid.NewGuid();
            _taskRepository.Add(task);
        }

        public void Update(Domain.Models.Task task)
        {
            _taskRepository.Update(task);
        }

        public void Remove(Guid id)
        {
            _taskRepository.Remove(id);
        }
    }
}
