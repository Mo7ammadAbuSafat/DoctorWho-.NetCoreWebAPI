using DoctorWho.Db.DbContexts;
using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : ICrudRepository<Author>, IAuthorRepository
    {
        private DoctorWhoCoreDbContext context;

        public AuthorRepository(DoctorWhoCoreDbContext context) : base(context) { }

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
