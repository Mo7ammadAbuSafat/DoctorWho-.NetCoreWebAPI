using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : ICrudRepository<Author>, IAuthorRepository
    {
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
