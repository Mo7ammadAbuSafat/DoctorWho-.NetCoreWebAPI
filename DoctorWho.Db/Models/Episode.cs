namespace DoctorWho.Db.Models
{
    public class Episode
    {
        public Episode()
        {
            enemyEpisode = new List<EnemyEpisode>();
            companionEpisode = new List<CompanionEpisode>();
        }
        public int Id { get; set; }
        public int SeriesNumber { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int AuthorId { get; set; }
        public int? DoctorId { get; set; }
        public ICollection<EnemyEpisode> enemyEpisode { get; set; }
        public ICollection<CompanionEpisode> companionEpisode { get; set; }

    }
}
