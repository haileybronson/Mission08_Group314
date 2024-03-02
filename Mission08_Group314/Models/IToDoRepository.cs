namespace Mission08_Group314.Models
{
    public interface IToDoRepository
    {
        List<ToDo> ToDos { get; }
        void AddToDo(ToDo toDo);
        void Update(ToDo toDo);
        void Delete(ToDo deletedRecord);
        ToDo GetTaskId(int id);
    }
}
