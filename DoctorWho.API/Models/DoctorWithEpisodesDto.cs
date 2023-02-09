namespace DoctorWho.API.Models
{
    public class DoctorWithEpisodesDto
    {
        public DoctorWithEpisodesDto()
        {
            Episodes = new List<EpisodeDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public ICollection<EpisodeDto> Episodes { get; set; }
    }
}
