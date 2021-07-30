using Microsoft.EntityFrameworkCore.Migrations;

namespace ArisCorpWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alienrassen",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Rasse = table.Column<string>(nullable: true),
                    PictureEinleitung = table.Column<string>(nullable: true),
                    PictureGeschichte = table.Column<string>(nullable: true),
                    PictureHeimatwelt = table.Column<string>(nullable: true),
                    PicturePolitik = table.Column<string>(nullable: true),
                    PictureDiplomatie = table.Column<string>(nullable: true),
                    PictureSprache = table.Column<string>(nullable: true),
                    PictureReligion = table.Column<string>(nullable: true),
                    PictureMilitar = table.Column<string>(nullable: true),
                    PictureKriminalitat = table.Column<string>(nullable: true),
                    PictureKultur = table.Column<string>(nullable: true),
                    PictureBesuch = table.Column<string>(nullable: true),
                    PictureSicherheit = table.Column<string>(nullable: true),
                    Einleitung = table.Column<string>(nullable: true),
                    Geschichte = table.Column<string>(nullable: true),
                    Heimatwelt = table.Column<string>(nullable: true),
                    Politik = table.Column<string>(nullable: true),
                    Diplomatie = table.Column<string>(nullable: true),
                    Sprache = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Militar = table.Column<string>(nullable: true),
                    Kriminalitat = table.Column<string>(nullable: true),
                    Kultur = table.Column<string>(nullable: true),
                    Besuch = table.Column<string>(nullable: true),
                    Sicherheit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alienrassen", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alienrassen");
        }
    }
}
