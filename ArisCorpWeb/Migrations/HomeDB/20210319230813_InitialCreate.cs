using Microsoft.EntityFrameworkCore.Migrations;

namespace ArisCorpWeb.Migrations.HomeDB
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    About = table.Column<string>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    Manifest = table.Column<string>(nullable: true),
                    Charter = table.Column<string>(nullable: true),
                    Member = table.Column<string>(nullable: true),
                    Fleet = table.Column<string>(nullable: true),
                    Partner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Home");
        }
    }
}
