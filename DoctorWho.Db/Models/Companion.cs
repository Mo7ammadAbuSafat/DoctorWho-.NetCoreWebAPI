namespace DoctorWho.Db.Models
{
    public class Companion
    {
        public Companion()
        {
            companionEpisodes = new List<CompanionEpisode>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string WhoPlayed { get; set; }
        public ICollection<CompanionEpisode>? companionEpisodes { get; set; }
    }
}
