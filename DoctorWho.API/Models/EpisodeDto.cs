namespace DoctorWho.API.Models
{
    public class EpisodeDto
    {
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
