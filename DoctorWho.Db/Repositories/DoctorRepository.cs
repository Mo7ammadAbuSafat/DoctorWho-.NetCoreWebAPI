using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : ICrudRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DoctorWhoCoreDbContext context) : base(context) { }

        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return await context.doctors.ToListAsync();
        }

        public async Task<Doctor>? GetDoctorById(int id)
        {
            return await context.doctors.FindAsync(id);
        }
    }
}
