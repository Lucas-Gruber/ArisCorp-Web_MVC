using Microsoft.EntityFrameworkCore.Migrations;

namespace ArisCorpWeb.Migrations
{
    public partial class InitialCreate : Migration
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
                    Picture = table.Column<string>(nullable: true),
                    Content1 = table.Column<string>(nullable: true),
                    Content2 = table.Column<string>(nullable: true),
                    Content3 = table.Column<string>(nullable: true),
                    Content4 = table.Column<string>(nullable: true)
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
