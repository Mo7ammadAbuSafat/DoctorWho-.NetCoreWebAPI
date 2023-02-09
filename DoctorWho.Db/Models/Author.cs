namespace DoctorWho.Db.Models
{
    public class Author
    {
        public Author()
        {
            Episodes = new List<Episode>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Episode> Episodes { get; set; }
    }
}
