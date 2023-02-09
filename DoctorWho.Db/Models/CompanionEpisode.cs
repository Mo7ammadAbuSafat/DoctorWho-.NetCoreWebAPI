namespace DoctorWho.Db.Models
{
    public class CompanionEpisode
    {
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public Episode episode { get; set; }
        public int CompanionId { get; set; }
        public Companion companion { get; set; }
    }
}
