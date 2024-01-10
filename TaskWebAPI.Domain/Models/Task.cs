namespace TaskWebAPI.Domain.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DeveloperName { get; set; }
        public string ProductOwnerName { get; set; }
    }
}
