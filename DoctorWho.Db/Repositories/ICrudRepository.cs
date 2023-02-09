using DoctorWho.Db.DbContexts;

namespace DoctorWho.Db.Repositories
{
    public abstract class ICrudRepository<T>
    {
        protected readonly DoctorWhoCoreDbContext context;
        public ICrudRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T Item)
        {
            await context.AddAsync(Item);
        }

        public void Update(T Item)
        {
            context.Update(Item);
        }

        public void Delete(T Item)
        {
            context.Remove(Item);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
