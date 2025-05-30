using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Repositories;

namespace LivrariaControleEmprestimo.DATA
{
    public class Class1
    {
        RepositoryCliente repow { get; set; }

        public Class1()
        {
            repow = new RepositoryCliente();
            Cliente cliente = new Cliente {
                CliBairro = "Bairro", 
                CliCidade = "Santos", 
                CliCpf = "1111111111", 
                CliEndereco  = "Rua Teste", 
                CliNome = "Mateste" , 
                CliNumero = "11", 
                CliTelefoneCelular = "122212", 
                CliTelefoneFixo = "Testeeee"
            };
            repow.Incluir(cliente);
        }

    }
}
