using Microsoft.AspNetCore.Mvc;

namespace Tarefas2.Controllers
{
    public class TarefasControlle : Controller
    {
        public IActionResult Index(){
            return View();
        }        
    }
}