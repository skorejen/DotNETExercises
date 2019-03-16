using Microsoft.EntityFrameworkCore;

namespace data
{
    public class TodoContext : DbContext {

        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

        }

        public DbSet<Todo> Todos {get; set;}
    }
}