using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorWhoCoreDbContext context;
        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public async Task AddAsync(Doctor doctor)
        {
            await context.doctors.AddAsync(doctor);
        }

        public void DeleteAsync(Doctor doctor)
        {
            context.doctors.Remove(doctor);
        }

        public void UpdateAsync(Doctor doctor)
        {
            context.doctors.Update(doctor);
        }

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
