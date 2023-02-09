using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : ICompanionRepository
    {
        private readonly DoctorWhoCoreDbContext context;
        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;

        }

        public async Task AddAsync(Companion companion)
        {
            await context.companions.AddAsync(companion);
        }

        public void DeleteAsync(Companion companion)
        {
            context.companions.Remove(companion);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void UpdateAsync(Companion companion)
        {
            context.companions.Update(companion);
        }

        public async Task<List<Companion>> GetAllCompanionsAsync()
        {
            return await context.companions.ToListAsync();
        }

        public async Task<Companion>? GetCompanionById(int id)
        {
            return await context.companions.FindAsync(id);
        }
    }
}