﻿using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryLivroClienteEmprestimo : RepositoryBase<LivroClienteEmprestimo>, IRepositoryLivroControleEmprestimo
    {
        public RepositoryLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {
            
        }
    }
}
