using Core;
using Entity;

namespace Data.Repository
{
    public class TodoListRepository : Repository<TodoList>, ITodoListRepository
    {
        public TodoListRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}