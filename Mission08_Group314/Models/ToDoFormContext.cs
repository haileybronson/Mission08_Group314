using Microsoft.EntityFrameworkCore;

namespace Mission08_Group314.Models
{
    public class ToDoFormContext :DbContext
    {
        public ToDoFormContext(DbContextOptions<ToDoFormContext> options): base(options) 
        { 
        }

        //do I need to change ToDo?

        public DbSet<ToDo> ToDo { get; set; }

    }
}
