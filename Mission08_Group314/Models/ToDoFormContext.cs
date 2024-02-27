using Microsoft.EntityFrameworkCore;

namespace Mission08_Group314.Models
{
    public class ToDoFormContext :DbContext
    {
        public ToDoFormContext(DbContextOptions<ToDoFormContext> options): base(options) 
        { 
        }

        //calls the class in the model, sets it to the table of the DB 
        public DbSet<ToDo> ToDo { get; set; }

    }
}
