namespace TaskWebAPI.Infrastructure.Repositories.Tasks
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<Domain.Models.Task> _tasks;

        public TaskRepository()
        {
            _tasks = new List<Domain.Models.Task>();
        }

        public List<Domain.Models.Task> GetAll()
        {
            return _tasks;
        }

        public Domain.Models.Task GetById(Guid id)
        {
            return _tasks.Find(p => p.Id == id);
        }

        public void Add(Domain.Models.Task task)
        {
            _tasks.Add(task);
        }

        public void Update(Domain.Models.Task task)
        {
            var index = _tasks.FindIndex(p => p.Id == task.Id);
            if (index != -1)
                _tasks[index] = task;
        }

        public void Remove(Guid id)
        {
            var task = _tasks.Find(p => p.Id == id);
            if (task != null)
                _tasks.Remove(task);
        }
    }
}
