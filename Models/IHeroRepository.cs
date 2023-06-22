namespace Ionic_II.Models
{
    public interface IHeroRepository
    {
        // Hero
        Task<Hero[]> GetAllHeroesAsync();

        Task<Hero> GetHeroAsync(int heroId);

    }
}
