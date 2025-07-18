﻿using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class VwLivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwLivroClienteEmprestimo { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryLivroClienteEmprestimo oRepositoryLivroClienteEmprestimo { get; set; }

        public VwLivroClienteEmprestimoService()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryCliente = new RepositoryCliente();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryLivroClienteEmprestimo = new RepositoryLivroClienteEmprestimo();
        }
    }
}
