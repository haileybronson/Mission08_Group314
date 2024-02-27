namespace Mission08_Group314.Models
{
    public class EFToDoRepository: IToDoRepository
    {
        private ToDoFormContext _context;

        public EFToDoRepository(ToDoFormContext temp)
        {
            _context = temp;
        }

        public List<ToDo> ToDos => _context.ToDo.ToList();

        public void AddToDo(ToDo ToDo)
        {
            _context.Add(ToDo);
            _context.SaveChanges();
        }
    }
}
