using Microsoft.EntityFrameworkCore;

namespace Mission08_Group314.Models
{
    public class ToDoFormContext :DbContext
    {
        public ToDoFormContext(DbContextOptions<ToDoFormContext> options): base(options) 
        { 
        }

        public DbSet<ToDo> ToDos { get; set; }

    }
}
