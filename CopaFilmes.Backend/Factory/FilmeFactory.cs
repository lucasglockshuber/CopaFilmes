using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Factory
{
    public static class FilmeFactory
    {
        public static IFilme Criar(string id, string titulo, double nota, string anoLancamento = null)
        {
            return new Filme(id, titulo, nota, anoLancamento);
        }
    }
}