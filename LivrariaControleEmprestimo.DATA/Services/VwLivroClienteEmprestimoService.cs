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


        public VwLivroClienteEmprestimoService()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
        }
    }
}
