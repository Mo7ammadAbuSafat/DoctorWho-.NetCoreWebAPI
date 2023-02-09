using DoctorWho.Db.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DoctorWho.Db.Services
{
    public class GeneralServices
    {
        private DoctorWhoCoreDbContext context { get; set; }
        public GeneralServices(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }

        public void CallFnCompanions(int Id)
        {
            var companions = context.companions.Select(c => context.FnCompanions(Id)).FirstOrDefault();
            Console.WriteLine(companions);
        }

        public void CallFnEnemies(int Id)
        {
            var enemies = context.companions.Select(c => context.FnEnemies(Id)).FirstOrDefault();
            Console.WriteLine(enemies);
        }

        public void DisplayViewEpisodes()
        {
            var episodes = context.viewEpisodes.ToList();

            foreach (var episode in episodes)
            {
                Console.WriteLine(episode.Id);
                Console.WriteLine(episode.Title);
                Console.WriteLine(episode.AutherName);
                Console.WriteLine(episode.DoctorName);
                Console.WriteLine(episode.Companions);
                Console.WriteLine(episode.Enemies);
                Console.WriteLine();
            }
        }

        public void CallSPSammarizeEpisodes()
        {
            var connection = context.Database.GetDbConnection();
            var command = connection.CreateCommand();
            command.CommandText = "dbo.spSummariseEpisodes";
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {

                        if (reader.GetFieldType(i) == typeof(int))
                        {
                            var columnValue = reader.GetInt32(i);
                            Console.Write($"{columnValue}  ");
                        }
                        else if (reader.GetFieldType(i) == typeof(string))
                        {
                            var columnValue = reader.GetString(i);
                            Console.Write($"{columnValue}  ");
                        }
                    }
                    Console.WriteLine();
                }
                reader.NextResult();
            }
            connection.Close();
        }
    }
}
