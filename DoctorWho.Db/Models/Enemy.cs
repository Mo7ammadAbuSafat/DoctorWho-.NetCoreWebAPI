namespace DoctorWho.Db.Models
{
    public class Enemy
    {
        public Enemy()
        {
            enemyEpisodes = new List<EnemyEpisode>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<EnemyEpisode> enemyEpisodes { get; set; }
    }
}
