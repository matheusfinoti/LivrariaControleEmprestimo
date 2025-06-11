using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Cliente? oCliente { get; set; }
        public List<Cliente>? oListClientes { get; set; }
        public int idCliente { get; set; }
        public Livro? oLivro { get; set; }
        public List<Livro>? oListLivros { get; set; }
        public int idLivro { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }
        public bool entregue { get; set; }
    }
}
