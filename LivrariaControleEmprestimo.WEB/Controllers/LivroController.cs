using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Services;
using System.Diagnostics.CodeAnalysis;


namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        public LivroService oLivroService = new LivroService();


        public IActionResult Index()
        {
            List<Livro> oListaLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListaLivro);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            oLivroService.oRepositoryLivro.Incluir(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPk(id);

            return View(oLivro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Alterar(model);
            return RedirectToAction("Details", new { id = model.Id });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Livro oLivro = oLivroService.oRepositoryLivro.SelecionarPk(id);

            if (oLivro == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(oLivro);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            oLivroService.oRepositoryLivro.Excluir(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
