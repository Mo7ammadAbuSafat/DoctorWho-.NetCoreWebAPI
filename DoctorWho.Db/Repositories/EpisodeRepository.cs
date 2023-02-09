using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly DoctorWhoCoreDbContext context;
        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;

        }
        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async Task AddAsync(Episode episode)
        {
            await context.episodes.AddAsync(episode);
        }

        public void DeleteAsync(Episode episode)
        {
            context.episodes.Remove(episode);
        }

        public void UpdateAsync(Episode episode)
        {
            context.episodes.Update(episode);
        }

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
