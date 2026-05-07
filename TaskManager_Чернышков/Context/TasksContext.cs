using Microsoft.EntityFrameworkCore;
using TaskManager_Чернышков.Classes.Database;

namespace TaskManager_Чернышков.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TasksContext()
        {
            Database.EnsureCreated();
            Tasks.Load();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseMySql(Config.connection, Config.version);
        
    }
}
