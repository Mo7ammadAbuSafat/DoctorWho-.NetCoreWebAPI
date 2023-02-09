namespace DoctorWho.API.Models
{
    public class DoctorForCreationDto
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? FirstEpisodeDate { get; set; }
        public DateTime? LastEpisodeDate { get; set; }
    }
}
