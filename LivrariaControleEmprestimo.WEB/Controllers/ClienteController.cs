using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {

        public ClienteService oClienteService = new ClienteService();

        public IActionResult Index()
        {
            List<Cliente> oListaCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListaCliente);
        }

        [HttpGet]
        public IActionResult Create() { return View(); }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // Retorna com os erros
            }

            oClienteService.oRepositoryCliente.Incluir(model);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente oCliente = oClienteService.oRepositoryCliente.SelecionarPk(id);

            return View(oCliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Alterar(model);
            return RedirectToAction("Details", new { id = model.Id });

        }

        public IActionResult Details(int id)
        {
            Cliente oCliente = oClienteService.oRepositoryCliente.SelecionarPk(id);



            return View(oCliente);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            oClienteService.oRepositoryCliente.Excluir(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
