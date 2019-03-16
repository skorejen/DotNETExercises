using System.Collections;

namespace todos
{
    public class TodoList{

        public ArrayList Todos {get; set;} // stoes TodoItem objects

        public TodoItem AddTodoItem(TodoItem todo) {
            Todos.Add(todo);
            if (todo.Equals(GetLatestTodo())) {
            return todo;

            } 
            return null;
        }

        private TodoItem GetLatestTodo() {
           TodoItem i = (TodoItem) Todos[Todos.Count-1];
        return i;
        }

        public TodoItem[] GetAllTodos() {
            TodoItem[] todosList = new TodoItem[Todos.Count];
            for(int i=0; i<Todos.Count; i++) {
                todosList[i] = (TodoItem) Todos[i];
            }
            return todosList;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}