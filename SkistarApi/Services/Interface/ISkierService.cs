using SkistarApi.Dtos;

namespace SkistarApi.Services.Interface;

public interface ISkierService
{
    Task<IEnumerable<SkierDto>> GetAllSkiers();
    Task<SkierDto> GetMyFavoriteSkier(int id);
}
