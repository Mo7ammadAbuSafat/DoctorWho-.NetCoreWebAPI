using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository : ICrudRepository<Episode>, IEpisodeRepository
    {
        public EpisodeRepository(DoctorWhoCoreDbContext context) : base(context) { }

        public async Task<List<Episode>> GetAllEpisodesAsync()
        {
            return await context.episodes.ToListAsync();
        }

        public async Task<Episode>? GetEpisodeByIdAsync(int id)
        {
            return await context.episodes.FindAsync(id);
        }

        public async Task AddEnemyToEpisodeAsync(Enemy enemy, Episode episode)
        {
            await context.Set<EnemyEpisode>().AddAsync(new EnemyEpisode()
            {
                enemy = enemy,
                episode = episode
            });
        }

        public async Task AddCompanionToEpisodeAsync(Companion companion, Episode episode)
        {
            await context.Set<CompanionEpisode>().AddAsync(new CompanionEpisode()
            {
                companion = companion,
                episode = episode
            });
        }
    }
}
