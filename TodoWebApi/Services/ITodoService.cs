using System.Collections.Generic;
using TodoWebApi.Model;

namespace TodoWebApi.Services
{
    public interface ITodoService
    {
        List<Todo> GetListTodo(int maxItem);
    }
}