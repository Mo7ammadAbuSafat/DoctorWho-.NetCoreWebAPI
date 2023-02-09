namespace DoctorWho.Db.Models
{
    public class EnemyEpisode
    {
        public int Id { get; set; }
        public int EnemyId { get; set; }
        public Enemy enemy { get; set; }
        public int EpisodeId { get; set; }
        public Episode episode { get; set; }
    }
}
