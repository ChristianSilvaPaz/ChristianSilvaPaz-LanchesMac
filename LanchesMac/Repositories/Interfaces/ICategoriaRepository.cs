using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces;

public interface ICategoriaRepository
{
    public IEnumerable<Categoria> Categorias { get; }
}
