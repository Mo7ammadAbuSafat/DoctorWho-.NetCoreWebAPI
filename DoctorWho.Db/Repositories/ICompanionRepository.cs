using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface ICompanionRepository
    {
        public Task<List<Companion>> GetAllCompanionsAsync();
        public Task<Companion>? GetCompanionById(int id);
        public Task<int> SaveChangesAsync();
        public Task AddAsync(Companion companion);
        public void DeleteAsync(Companion companion);
        public void UpdateAsync(Companion companion);
    }
}