using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class addSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE spSummariseEpisodes
                                    AS
                                    BEGIN	
	                                    SELECT TOP 3 C.Name, COUNT(*) AS CountAppearing
	                                    FROM episodeCompanions EC LEFT JOIN companions C
	                                    ON C.Id = EC.CompanionId 
	                                    GROUP BY C.Name
	                                    ORDER BY COUNT(*) DESC;

	                                    SELECT TOP 3 E.Name, COUNT(*) AS CountAppearing
	                                    FROM episodeEnemies EE LEFT JOIN enemys E  ON E.Id = EE.EnemyId 
	                                    GROUP BY E.Name
	                                    ORDER BY COUNT(*) DESC;
                                    END;"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE IF EXISTS spSummariseEpisodes;");
        }
    }
}
