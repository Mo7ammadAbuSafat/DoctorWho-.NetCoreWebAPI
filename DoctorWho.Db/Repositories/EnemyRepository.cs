using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : IEnemyRepository
    {
        private readonly DoctorWhoCoreDbContext context;
        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;

        }

        public async Task AddAsync(Enemy enemy)
        {
            await context.enemys.AddAsync(enemy);
        }

        public void DeleteAsync(Enemy enemy)
        {
            context.enemys.Remove(enemy);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void UpdateAsync(Enemy enemy)
        {
            context.enemys.Update(enemy);
        }

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
