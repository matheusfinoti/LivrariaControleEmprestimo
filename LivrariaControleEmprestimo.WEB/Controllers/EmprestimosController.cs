using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        VwLivroClienteEmprestimoService _service = new VwLivroClienteEmprestimoService();

        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oList = _service.oRepositoryVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oList);
        }
    }
}
