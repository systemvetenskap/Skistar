using SkistarApi.Data;
using SkistarApi.Models;
using SkistarApi.Repositories.Interface;

namespace SkistarApi.Repositories
{
    public class SkierRepository : Repository<Skier>, ISkierRepository
    {
        private readonly AppDbContext _context;

        public SkierRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Skier> GetSkierByIdAsync(int id)
        {
            return await GetByIdAsync(id);
            //return await GetAllAsync();
            //return await _context.Skiers.ToListAsync();
        }
        public async Task<IEnumerable<Skier>> GetSkiers()
        {
            return await GetAllAsync();
        }
        // hämta en skidåkare och alla åken som har gjorts i en specifik lift en specfik dag

    }
}
