namespace DoctorWho.Db.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Episodes = new List<Episode>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public ICollection<Episode> Episodes { get; set; }

    }
}
