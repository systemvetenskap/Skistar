using SkistarApi.Dtos;
using SkistarApi.Repositories.Interface;
using SkistarApi.Services.Interface;

namespace SkistarApi.Services
{
    public class SkierService : ISkierService
    {
        private readonly ISkierRepository _skierRepository;

        // välj alla skidåkare
        // hämta min specika fråga
        public SkierService(ISkierRepository skierRepository)
        {
            _skierRepository = skierRepository;
        }
        public async Task<SkierDto> GetMyFavoriteSkier(int id)
        {
            // i vår service. Lägg ALLA valideringar och annan C# kod
            var topSkier = await _skierRepository.GetSkierByIdAsync(id);
            var dto = new SkierDto
            {
                Name = topSkier.Name
            };
            return dto;
            // returnear istället en dto

        }

        public async Task<IEnumerable<SkierDto>> GetAllSkiers()
        {
            //var skiers = _skierRepository.GetSkiers();
            //List<SkierDto> skierDtos = new List<SkierDto>();
            //foreach (var skier in skiers)
            //{
            //    // ny dto
            //}
            //return skiers;
            return null;
        }
    }
}
