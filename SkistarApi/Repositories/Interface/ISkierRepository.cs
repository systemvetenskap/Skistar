using SkistarApi.Models;

namespace SkistarApi.Repositories.Interface;

public interface ISkierRepository
{
    Task<Skier> GetSkierByIdAsync(int id);
    Task<IEnumerable<Skier>> GetSkiers();
}
