using ProvaH1.Controllers;
using ProvaH1.Models;

namespace ProvaH1.Repository
{
    public class ProvaRepository : IProvaRepository
    {
        private static List<Jogador> ListaJogador = new List<Jogador>();
        private static List<Peneira> ListaPeneira = new List<Peneira>();

        public void Cadastrar(Jogador jogador)
        {
            if (ListaJogador.Any(c => c.CPF == jogador.CPF))
            {
                throw new Exception("Jogador já cadastrado!");
            }
            ListaJogador.Add(jogador);
        }
        public List<Jogador> ObterTodos()
        {
            return ListaJogador;
        }
        public void Registrar(Peneira aprovado)
        {
            ListaPeneira.Add(aprovado);
        }
    }
}