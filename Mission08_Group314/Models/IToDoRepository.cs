namespace Mission08_Group314.Models
{
    public interface IToDoRepository
    {
        List<ToDo> ToDos { get; }
        public void AddToDo(ToDo ToDo);
    }
}
