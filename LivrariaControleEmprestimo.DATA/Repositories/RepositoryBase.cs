﻿using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected ControleEmprestimoLivroContext _Context;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Context = new ControleEmprestimoLivroContext();
        }
        public T Alterar(T objeto)
        {
            _Context.Entry(objeto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            if (_SaveChanges)
            {
                _Context.SaveChanges();
            }   
            return objeto;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public void Excluir(T objeto)
        {
            _Context.Set<T>().Remove(objeto);
            if (_SaveChanges)
            {
                _Context.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            _Context.Set<T>().Add(objeto);
            if (_SaveChanges)
            {
                _Context.SaveChanges();
            }
            return objeto;
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel) => _Context.Set<T>().Find(variavel);

        public List<T> SelecionarTodos()
        {
            return _Context.Set<T>().ToList();
        }
    }
}
