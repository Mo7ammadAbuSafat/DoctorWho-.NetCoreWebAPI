using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.DbContexts
{
    public class DoctorWhoCoreDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ABUSAFAT;Initial Catalog=DoctorWhoCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Author>().Property(a => a.Name).HasColumnType("varchar(20)");

            modelBuilder.Entity<Companion>().HasKey(c => c.Id);
            modelBuilder.Entity<Companion>().Property(a => a.Name).HasColumnType("varchar(20)");
            modelBuilder.Entity<Companion>().Property(a => a.WhoPlayed).HasColumnType("varchar(100)");

            modelBuilder.Entity<Doctor>().HasKey(d => d.Id);
            modelBuilder.Entity<Doctor>().Property(a => a.Name).HasColumnType("varchar(20)");

            modelBuilder.Entity<Enemy>().HasKey(e => e.Id);
            modelBuilder.Entity<Enemy>().Property(e => e.Name).HasColumnType("varchar(20)");
            modelBuilder.Entity<Enemy>().Property(e => e.Description).HasColumnType("varchar(200)");

            modelBuilder.Entity<Episode>().HasKey(e => e.Id);
            modelBuilder.Entity<Episode>().Property(e => e.Type).HasColumnType("varchar(100)");
            modelBuilder.Entity<Episode>().Property(e => e.Title).HasColumnType("varchar(100)");
            modelBuilder.Entity<Episode>().Property(e => e.Notes).HasColumnType("varchar(200)");



            modelBuilder.Entity<Enemy>().HasData(
                new Enemy { Id = 1, Name = "Enemy1", Description = "Description1" },
                new Enemy { Id = 2, Name = "Enemy2", Description = "Description2" },
                new Enemy { Id = 3, Name = "Enemy3", Description = "Description3" },
                new Enemy { Id = 4, Name = "Enemy4", Description = "Description4" },
                new Enemy { Id = 5, Name = "Enemy5", Description = "Description5" }
                );

            modelBuilder.Entity<Companion>().HasData(
                new Companion { Id = 1, Name = "Companion1", WhoPlayed = "x" },
                new Companion { Id = 2, Name = "Companion2", WhoPlayed = "y" },
                new Companion { Id = 3, Name = "Companion3", WhoPlayed = "z" },
                new Companion { Id = 4, Name = "Companion4", WhoPlayed = "e" },
                new Companion { Id = 5, Name = "Companion5", WhoPlayed = "w" }
                );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Number = 1, Name = "Doctor1", BirthDate = new DateTime(1900, 02, 04), FirstEpisodeDate = new DateTime(1912, 01, 03), LastEpisodeDate = new DateTime(1941, 03, 02) },
                new Doctor { Id = 2, Number = 2, Name = "Doctor2", BirthDate = new DateTime(1950, 02, 07), FirstEpisodeDate = new DateTime(1950, 12, 09), LastEpisodeDate = new DateTime(1901, 01, 11) },
                new Doctor { Id = 3, Number = 3, Name = "Doctor3", BirthDate = new DateTime(1959, 07, 07), FirstEpisodeDate = new DateTime(1900, 05, 03), LastEpisodeDate = new DateTime(1944, 08, 18) },
                new Doctor { Id = 4, Number = 4, Name = "Doctor4", BirthDate = new DateTime(1927, 07, 12), FirstEpisodeDate = new DateTime(1924, 12, 08), LastEpisodeDate = new DateTime(1941, 03, 21) },
                new Doctor { Id = 5, Number = 5, Name = "Doctor5", BirthDate = new DateTime(1992, 07, 12), FirstEpisodeDate = new DateTime(1942, 03, 07), LastEpisodeDate = new DateTime(1944, 12, 06) }
                );

            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Author1" },
                new Author { Id = 2, Name = "Author2" },
                new Author { Id = 3, Name = "Author3" },
                new Author { Id = 4, Name = "Author4" },
                new Author { Id = 5, Name = "Author5" }
                );

            modelBuilder.Entity<Episode>().HasData(
                new Episode
                {
                    Id = 1,
                    SeriesNumber = 1,
                    Number = 1,
                    Type = "type1",
                    Title = "Title1",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note1",
                    AuthorId = 3,
                    DoctorId = 1
                },
                new Episode
                {
                    Id = 2,
                    SeriesNumber = 2,
                    Number = 2,
                    Type = "type2",
                    Title = "Title2",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note2",
                    AuthorId = 2,
                    DoctorId = 5
                },
                new Episode
                {
                    Id = 3,
                    SeriesNumber = 3,
                    Number = 3,
                    Type = "type3",
                    Title = "Title3",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note3",
                    AuthorId = 2,
                    DoctorId = 2
                },
                new Episode
                {
                    Id = 4,
                    SeriesNumber = 4,
                    Number = 4,
                    Type = "type4",
                    Title = "Title4",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note4",
                    AuthorId = 1,
                    DoctorId = 5
                },
                new Episode
                {
                    Id = 5,
                    SeriesNumber = 5,
                    Number = 5,
                    Type = "type5",
                    Title = "Title5",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note5",
                    AuthorId = 3,
                    DoctorId = null
                },
                new Episode
                {
                    Id = 6,
                    SeriesNumber = 6,
                    Number = 6,
                    Type = "type6",
                    Title = "Title6",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note6",
                    AuthorId = 2,
                    DoctorId = 1
                },
                new Episode
                {
                    Id = 7,
                    SeriesNumber = 7,
                    Number = 7,
                    Type = "type7",
                    Title = "Title7",
                    Date = new DateTime(1900, 02, 04),
                    Notes = "Note7",
                    AuthorId = 5,
                    DoctorId = null
                }
                );

            modelBuilder.Entity<CompanionEpisode>().HasData(
                new CompanionEpisode { Id = 1, CompanionId = 2, EpisodeId = 3, },
                new CompanionEpisode { Id = 2, CompanionId = 1, EpisodeId = 1, },
                new CompanionEpisode { Id = 3, CompanionId = 2, EpisodeId = 2, },
                new CompanionEpisode { Id = 4, CompanionId = 3, EpisodeId = 2, },
                new CompanionEpisode { Id = 5, CompanionId = 5, EpisodeId = 4 }
                );

            modelBuilder.Entity<EnemyEpisode>().HasData(
                new EnemyEpisode { Id = 1, EnemyId = 2, EpisodeId = 3, },
                new EnemyEpisode { Id = 2, EnemyId = 1, EpisodeId = 2, },
                new EnemyEpisode { Id = 3, EnemyId = 5, EpisodeId = 2, },
                new EnemyEpisode { Id = 4, EnemyId = 2, EpisodeId = 2, },
                new EnemyEpisode { Id = 5, EnemyId = 5, EpisodeId = 1, },
                new EnemyEpisode { Id = 6, EnemyId = 3, EpisodeId = 3, },
                new EnemyEpisode { Id = 7, EnemyId = 2, EpisodeId = 4, },
                new EnemyEpisode { Id = 8, EnemyId = 2, EpisodeId = 1, },
                new EnemyEpisode { Id = 9, EnemyId = 1, EpisodeId = 3, }
                );

            modelBuilder.Entity<ViewEpisodes>().HasNoKey().ToView("viewEpisodes");

            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext).GetMethod(nameof(FnCompanions), new[] { typeof(int) }))
            .HasName("fnCompanions");

            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext).GetMethod(nameof(FnEnemies), new[] { typeof(int) }))
            .HasName("fnEnemies");
        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Companion> companions { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Episode> episodes { get; set; }
        public DbSet<Enemy> enemys { get; set; }
        public DbSet<CompanionEpisode> episodeCompanions { get; set; }
        public DbSet<EnemyEpisode> episodeEnemies { get; set; }
        public DbSet<ViewEpisodes> viewEpisodes { get; set; }

        public string FnCompanions(int EpisodeId) => throw new NotSupportedException();

        public string FnEnemies(int EpisodeId) => throw new NotSupportedException();

    }
}
