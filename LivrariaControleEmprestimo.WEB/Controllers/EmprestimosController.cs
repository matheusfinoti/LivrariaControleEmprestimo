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

            oEmprestimoViewModel.dataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7);


            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(EmprestimoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            LivroClienteEmprestimo livroClienteEmprestimo = new LivroClienteEmprestimo()
            {
                LceDataEmprestimo = model.dataEmprestimo,
                LceDataEntrega = model.dataEntrega,
                LceEntregue = false,
                LceIdCliente = model.idCliente,
                LceIdLivro = model.idLivro
            };


            _service.oRepositoryLivroClienteEmprestimo.Incluir(livroClienteEmprestimo);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();

            oEmprestimoViewModel.oListLivros = _service.oRepositoryLivro.SelecionarTodos();
            oEmprestimoViewModel.oListClientes = _service.oRepositoryCliente.SelecionarTodos();

            LivroClienteEmprestimo oLivroClienteEmprestimo = _service.oRepositoryLivroClienteEmprestimo.SelecionarPk(id);
            oEmprestimoViewModel.oLivroClienteEmprestimo = oLivroClienteEmprestimo;



            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Edit(EmprestimoViewModel oEmprestimoViewModel)
        {
            oEmprestimoViewModel.oListLivros = _service.oRepositoryLivro.SelecionarTodos();
            oEmprestimoViewModel.oListClientes = _service.oRepositoryCliente.SelecionarTodos();

            //if (!ModelState.IsValid)
            //{
            //    return View(oEmprestimoViewModel);
            //}


            _service.oRepositoryLivroClienteEmprestimo.Alterar(oEmprestimoViewModel.oLivroClienteEmprestimo);


            return RedirectToAction(nameof(Index)); ;
        }
    }
}
