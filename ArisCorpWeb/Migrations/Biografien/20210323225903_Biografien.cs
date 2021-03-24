using Microsoft.EntityFrameworkCore.Migrations;

namespace ArisCorpWeb.Migrations.Biografien
{
    public partial class Biografien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biografien",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Mitglied = table.Column<string>(nullable: true),
                    Titel = table.Column<string>(nullable: true),
                    Potrait = table.Column<string>(nullable: true),
                    Steckbrief = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Zusatz = table.Column<string>(nullable: true),
                    HomepageRolle = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biografien", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biografien");
        }
    }
}
