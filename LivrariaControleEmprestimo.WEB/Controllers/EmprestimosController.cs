using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
