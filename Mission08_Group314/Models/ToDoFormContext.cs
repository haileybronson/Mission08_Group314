using Microsoft.EntityFrameworkCore;

namespace Mission08_Group314.Models
{
    public class ToDoFormContext
    {
        public ToDoFormContext(DbContextOptions<ToDoFormContext> options): base(options) 
        { 
        }

        public DbSet<ToDo> ToDo { get; set; }

    }
}
