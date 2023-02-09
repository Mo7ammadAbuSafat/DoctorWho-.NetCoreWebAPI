using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : ICrudRepository<Doctor>, IDoctorRepository
    {
        public async Task<List<Doctor>> GetAllDoctorsWithoutEpisodesAsync()
        {
            return await context.doctors.ToListAsync();
        }

        public async Task<List<Doctor>> GetAllDoctorsWithEpisodesAsync()
        {
            return await context.doctors.Include(d => d.Episodes).ToListAsync();
        }

        public async Task<Doctor>? GetDoctorById(int id)
        {
            return await context.doctors.FindAsync(id);
        }
    }
}
