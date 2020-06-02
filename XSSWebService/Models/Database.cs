using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSWebService.Models
{
    public class Database
    {
        private static Database instance = null;
        private List<string> todos;

        private Database()
        {
            todos = new List<string>();
        }

        public static Database getInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public List<string> GetTodos()
        {
            return todos;
        }

        public void AddTodo(string todo)
        {
            todos.Add(todo);
        }
    }
}