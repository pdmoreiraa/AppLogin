using AppLogin.Models;

namespace AppLogin.Repository.Contract
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Smail, string Senha);

        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void Excluir(int Id);
        Colaborador ObterColaborador(int Id);
        List<Colaborador> ObterColaboradorPorEmail(string Email);
        IEnumerable<Colaborador> ObterTodosColaboradores();
        // IPaged<Cliente> ObterTodosCLientes(int? pagina, string pesquisa);
    }
}
