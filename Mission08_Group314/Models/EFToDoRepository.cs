namespace Mission08_Group314.Models
{
    public class EFToDoRepository: IToDoRepository
    {
        private ToDoFormContext _context;

        public EFToDoRepository(ToDoFormContext temp)
        {
            _context = temp;
        }

        public List<ToDo> ToDos => _context.ToDos.ToList();
    }
}
