using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class addView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW viewEpisodes AS
                                    SELECT E.Id, Title, A.Name AS AutherName, D.Name AS DoctorName, dbo.fnCompanions(E.Id) AS Companions, dbo.fnEnemies(E.Id) AS Enemies
                                    FROM episodes E
                                    JOIN doctors D ON E.DoctorId = D.Id
                                    JOIN authors A ON E.AuthorId = A.Id;"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS viewEpisodes;");
        }
    }
}
