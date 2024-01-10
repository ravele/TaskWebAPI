using TaskWebAPI.Domain.Models;

namespace TaskWebAPI.Infrastructure.Repositories.Tasks
{
    public interface ITaskRepository
    {
        List<Domain.Models.Task> GetAll();
        Domain.Models.Task GetById(Guid id);
        void Add(Domain.Models.Task task);
        void Update(Domain.Models.Task task);
        void Remove(Guid id);
    }
}
