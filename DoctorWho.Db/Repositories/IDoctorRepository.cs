using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IDoctorRepository
    {
        public Task<List<Doctor>> GetAllDoctorsWithEpisodesAsync();
        public Task<List<Doctor>> GetAllDoctorsWithoutEpisodesAsync();
        public Task<Doctor>? GetDoctorByIdAsync(int id);
        public Doctor? GetDoctorById(int id);
        public Task<int> SaveChangesAsync();
        public int SaveChanges();
        public Task AddAsync(Doctor doctor);
        public void Delete(Doctor doctor);
        public void Update(Doctor doctor);
    }
}