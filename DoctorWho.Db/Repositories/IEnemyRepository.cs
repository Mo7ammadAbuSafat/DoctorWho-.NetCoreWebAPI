using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IEnemyRepository
    {
        public Task<List<Enemy>> GetAllEnemiesAsync();
        public Task<Enemy>? GetEnemyById(int id);
        public Task<int> SaveChangesAsync();
        public Task AddAsync(Enemy enemy);
        public void Delete(Enemy enemy);
        public void Update(Enemy enemy);
    }
}