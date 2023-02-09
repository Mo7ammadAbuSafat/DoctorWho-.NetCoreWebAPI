using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IEnemyRepository
    {
        public Task<List<Enemy>> GetAllEnemiesAsync();
        public Task<Enemy>? GetEnemyById(int id);
    }
}