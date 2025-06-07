using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
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

        [HttpGet]
        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            oEmprestimoViewModel.oListLivros = _service.oRepositoryLivro.SelecionarTodos();
            oEmprestimoViewModel.oListClientes = _service.oRepositoryCliente.SelecionarTodos();


            return View(oEmprestimoViewModel);
        }
    }
}
