using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_NETServer.Models.DbEntity;

namespace TodoList_NETServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoListController : Controller
    {
        public IActionResult Index()
        {
            var todolist = _dbcontext.Set<TodoList>().ToList();
            return View();
        }

        private TodoList_Blazor_NET5Context _dbcontext;
        public TodoListController(TodoList_Blazor_NET5Context dbcontext) => _dbcontext = dbcontext;
    }
}
