using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities;

namespace TaskManager.Infrastructure.DataAccess
{
    internal class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions option) : base(option)
        {
            
        }
        DbSet<Domain.Entities.Task> tasks {  get; set; }
        DbSet<User> users { get; set; }
    }
}
