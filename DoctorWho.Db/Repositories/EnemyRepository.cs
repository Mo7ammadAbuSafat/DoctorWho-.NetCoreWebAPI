using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : ICrudRepository<Enemy>, IEnemyRepository
    {
        public async Task<List<Enemy>> GetAllEnemiesAsync()
        {
            return await context.enemys.ToListAsync();
        }

        public async Task<Enemy>? GetEnemyById(int id)
        {
            return await context.enemys.FindAsync(id);
        }

    }
}
