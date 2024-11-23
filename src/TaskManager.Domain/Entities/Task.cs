using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; set; }    
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ExpirationDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}