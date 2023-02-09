using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IEpisodeRepository
    {
        public Task<List<Episode>> GetAllEpisodesAsync();
        public Task<Episode>? GetEpisodeByIdAsync(int id);
        public Task AddEnemyToEpisodeAsync(Enemy enemy, Episode episode);
        public Task AddCompanionToEpisodeAsync(Companion companion, Episode episode);
    }
}