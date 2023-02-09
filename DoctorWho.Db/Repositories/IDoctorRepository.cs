using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IDoctorRepository
    {
        public Task<List<Doctor>> GetAllDoctorsWithEpisodesAsync();
        public Task<List<Doctor>> GetAllDoctorsWithoutEpisodesAsync();
        public Task<Doctor>? GetDoctorById(int id);
        public Task<int> SaveChangesAsync();
        public Task AddAsync(Doctor doctor);
        public void DeleteAsync(Doctor doctor);
        public void UpdateAsync(Doctor doctor);
    }
}