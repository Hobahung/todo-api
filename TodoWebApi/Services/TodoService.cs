using System.Collections.Generic;
using TodoWebApi.Model;

namespace TodoWebApi.Services
{
    public class TodoService: ITodoService
    {
        public List<Todo> GetListTodo(int maxItem)
        {
            var arrTodo = new List<Todo>();
            for (int i = 0; i < maxItem; i++)
            {
                var todo = new Todo()
                {
                    Id = i,
                    Name = "Ho Ba Hung",
                    Status = 0,
                    People = new People()
                    {
                        Id = 0,
                        Name = "Leo Laki"
                    }
                };
                arrTodo.Add(todo);
            }
            return arrTodo;
        }
    }
}