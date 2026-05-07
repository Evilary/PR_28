using Microsoft.EntityFrameworkCore;
using TaskManager_Чернышков.Classes.Database;
using TaskManager_Чернышков.Models;

namespace TaskManager_Чернышков.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; } = null!;

        public TasksContext()
        {
            Database.EnsureCreated();
            Set<Tasks>().Load();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseMySql(Config.connection, Config.version);
        
    }
}
