using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public Author? GetAuthorById(int id);
    }
}