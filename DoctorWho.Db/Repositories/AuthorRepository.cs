using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DoctorWhoCoreDbContext context;
        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;

        }

        public async Task AddAsync(Author author)
        {
            await context.authors.AddAsync(author);
        }

        public void Delete(Author author)
        {
            context.authors.Remove(author);
        }

        public void Update(Author author)
        {
            context.authors.Update(author);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public List<Author> GetAllAuthors()
        {
            return context.authors.ToList();
        }

        public Author? GetAuthorById(int id)
        {
            return context.authors.Find(id);
        }
    }
}
