using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class addFunctions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION fnEnemies( @Id INT)
                                    RETURNS varchar(max)
                                    AS 
                                    BEGIN
                                    DECLARE @Result varchar(max)
                                    SELECT @Result = COALESCE(@Result + ', ','') + E.Name 
                                    FROM enemies E Left JOIN episodeEnemies EE 
                                    ON E.Id = EE.EnemyId 
                                    WHERE EE.EpisodeId = @Id
                                    return @Result;
                                    END;"
            );

            migrationBuilder.Sql(@"CREATE FUNCTION fnCompanions( @Id INT)
                                    RETURNS varchar(max)
                                    AS 
                                    BEGIN
                                    DECLARE @Result varchar(max)
                                    SELECT @Result = COALESCE(@Result + ', ','') + C.Name 
                                    FROM companions C RIGHT JOIN episodeCompanions EC 
                                    ON C.Id = EC.CompanionId 
                                    WHERE EC.EpisodeId = @Id
                                    return @Result;
                                    END;"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnEnemies;");

            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS fnCompanions;");
        }
    }
}
