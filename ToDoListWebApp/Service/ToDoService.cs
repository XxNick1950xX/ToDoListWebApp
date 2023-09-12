using Microsoft.EntityFrameworkCore;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Service
{
    public class ToDoService
    {
        public readonly ToDoContext context;
        public ToDoService(ToDoContext context) 
        {
            this.context = context;
        }

        public async Task<List<ToDo>> GetToDosAsync()
        {
            return await context.ToDos.ToListAsync();
        }

        public async Task AddAsync(ToDo toDo)
        {
            await context.ToDos.AddAsync(toDo);
            await context.SaveChangesAsync();
        }
    }
}
