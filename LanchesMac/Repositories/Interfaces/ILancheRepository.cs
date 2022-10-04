using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces;

public interface ILancheRepository
{
    public IEnumerable<Lanche> Lanches { get; }
    public IEnumerable<Lanche> LanchesPreferidos { get; }
    Lanche GetLancheById(int lancheId);
}
