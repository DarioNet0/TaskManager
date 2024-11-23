using Microsoft.EntityFrameworkCore;

namespace TaskManager.Infrastructure.DataAccess
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions option) : base(option)
        {
            
        }
    }
}
