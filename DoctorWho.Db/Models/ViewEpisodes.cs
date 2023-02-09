namespace DoctorWho.Db.Models
{
    public class ViewEpisodes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AutherName { get; set; }
        public string? DoctorName { get; set; }
        public string? Companions { get; set; }
        public string? Enemies { get; set; }
    }
}
