using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todos;

namespace ex03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        public TodoList todoList;
        public TodosController() {
            todoList = new TodoList {Todos = new ArrayList()};
            todoList.AddTodoItem(new TodoItem {Id = 1, Name = "Dick", isComplete= false});
       
            todoList.AddTodoItem(new TodoItem {Id = 2, Name = "Matej", isComplete= true});
       
        }
        // GET api/values
        [HttpGet]
        public ActionResult<TodoList> Get()
        {
            return todoList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
