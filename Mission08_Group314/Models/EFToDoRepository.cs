namespace Mission08_Group314.Models
{
    public class EFToDoRepository : IToDoRepository
    {
        private ToDoFormContext _context;

        public EFToDoRepository(ToDoFormContext context)
        {
            _context = context;
        }

        public List<ToDo> ToDos => _context.ToDo.ToList();

        public void AddToDo(ToDo toDo)
        {
            _context.Add(toDo);
            _context.SaveChanges();
        }

        public void Update(ToDo toDo)
        {
            _context.Update(toDo);
            _context.SaveChanges();
        }

        public void Delete(ToDo deletedRecord)
        {
            _context.ToDo.Remove(deletedRecord);
            _context.SaveChanges();
        }

        public ToDo GetTaskId(int id)
        {
            return _context.ToDo.FirstOrDefault(x => x.TaskId == id);
        }
    }
}

