using Microsoft.EntityFrameworkCore;
using TaskManager_Чернышков.Classes.Database;

namespace TaskManager_Чернышков.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskContext()
        {
            Database.EnsureCreated();
            Task.Load();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseMySql(Config.connection, Config.version);
        
    }
}
