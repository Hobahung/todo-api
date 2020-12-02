using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TodoWebApi.Model;
using TodoWebApi.Services;

namespace TodoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class TodoController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ITodoService _todoService;
        private int maxItem;
        
        public TodoController(IConfiguration config, ITodoService todoService)
        {
            _config = config;
            _todoService = todoService;
            this.maxItem = _config.GetValue<int>("MaxItem");
        }
        
        [HttpGet]
        public List<Todo> Get()
        {
            return _todoService.GetListTodo(maxItem);
        }
        
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            var todos= _todoService.GetListTodo(maxItem);
            todos.RemoveAt(todos.FindIndex((item) => item.Id == id));
            return true;
        }

        [HttpPost]
        public IActionResult Create(Todo newTodo)
        {
            return Accepted();
        }
    }
}