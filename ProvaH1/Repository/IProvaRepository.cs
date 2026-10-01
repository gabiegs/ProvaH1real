using ProvaH1.Controllers;
using ProvaH1.Models;

namespace ProvaH1.Repository
{
    public interface IProvaRepository
    {
        public void Cadastrar(Jogador jogador);
        public List<Jogador> ObterTodos();

        public void Registrar(Peneira peneira);
    }
}