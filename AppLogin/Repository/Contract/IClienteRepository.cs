using AppLogin.Models;

namespace AppLogin.Repository.Contract
{
    public interface IClienteRepository
    {
        Cliente Login(string Email, string Senha);

        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int Id);
        void Ativar(int Id);
        void Desativar(int Id);
        Cliente ObterCliente(int Id);
        IEnumerable<Cliente> ObterTodosClientes();
        // IPaged<Cliente> ObterTodosCLientes(int? pagina, string pesquisa);
    }
}
