using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public Author? GetAuthorById(int id);
        public Task<int> SaveChangesAsync();
        public Task AddAsync(Author author);
        public void Delete(Author author);
        public void Update(Author author);
    }
}