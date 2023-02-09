using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface ICompanionRepository
    {
        public Task<List<Companion>> GetAllCompanionsAsync();
        public Task<Companion>? GetCompanionById(int id);
    }
}