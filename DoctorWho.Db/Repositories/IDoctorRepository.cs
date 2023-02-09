using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IDoctorRepository
    {
        public Task<List<Doctor>> GetAllDoctorsAsync();
        public Task<Doctor>? GetDoctorById(int id);
    }
}