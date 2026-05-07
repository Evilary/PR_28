using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager_Чернышков.Classes.Database;
using TaskManager_Чернышков.Models;

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
