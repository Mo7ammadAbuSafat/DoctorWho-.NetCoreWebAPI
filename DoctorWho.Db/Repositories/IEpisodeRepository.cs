using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IEpisodeRepository
    {
        public Task<List<Episode>> GetAllEpisodesAsync();
        public Task<Episode>? GetEpisodeByIdAsync(int id);
        public Task AddEnemyToEpisodeAsync(Enemy enemy, Episode episode);
        public Task AddCompanionToEpisodeAsync(Companion companion, Episode episode);
        public Task<int> SaveChangesAsync();
        public Task AddAsync(Episode episode);
        public void Delete(Episode episode);
        public void Update(Episode episode);
    }
}