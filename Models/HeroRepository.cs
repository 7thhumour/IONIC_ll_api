using Microsoft.EntityFrameworkCore;

namespace Ionic_II.Models
{
    public class HeroRepository : IHeroRepository
    {
        private readonly AppDbContext _appDbContext;

        public HeroRepository(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }
        public async Task<Hero[]> GetAllHeroesAsync()
        {
            IQueryable<Hero> query = _appDbContext.Heroes;
            return await query.ToArrayAsync();
        }

        public async Task<Hero> GetHeroAsync(int heroId)
        {
            IQueryable<Hero> query = _appDbContext.Heroes.Where(c => c.HeroId == heroId);
            return await query.FirstOrDefaultAsync();
        }
    }
}
