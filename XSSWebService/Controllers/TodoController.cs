using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XSSWebService.Models;

namespace XSSWebService.Controllers
{
    public class TodoController : ApiController
    {
        private Database db = Database.getInstance();
        [Route("api/Todo/add")]
        [HttpPost]
        public void AddTodo([FromBody]string todo)
        {
            db.AddTodo(todo);
        }

        [Route("api/Todo/all")]
        [HttpGet]
        public List<string> GetTodos()
        {
            return db.GetTodos();
        }
    }
}