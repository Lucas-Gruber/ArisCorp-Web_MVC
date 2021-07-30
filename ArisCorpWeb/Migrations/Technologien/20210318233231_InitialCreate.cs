using Microsoft.EntityFrameworkCore.Migrations;

namespace ArisCorpWeb.Migrations.Technologien
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Technologien",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Rasse = table.Column<string>(nullable: true),
                    Extra1 = table.Column<string>(nullable: true),
                    Extra2 = table.Column<string>(nullable: true),
                    Extra3 = table.Column<string>(nullable: true),
                    Extra4 = table.Column<string>(nullable: true),
                    Extra5 = table.Column<string>(nullable: true),
                    Picture1 = table.Column<string>(nullable: true),
                    Picture2 = table.Column<string>(nullable: true),
                    Picture3 = table.Column<string>(nullable: true),
                    Picture4 = table.Column<string>(nullable: true),
                    Picture5 = table.Column<string>(nullable: true),
                    Picture6 = table.Column<string>(nullable: true),
                    Picture7 = table.Column<string>(nullable: true),
                    Picture8 = table.Column<string>(nullable: true),
                    Picture9 = table.Column<string>(nullable: true),
                    Picture10 = table.Column<string>(nullable: true),
                    Content1 = table.Column<string>(nullable: true),
                    Content2 = table.Column<string>(nullable: true),
                    Content3 = table.Column<string>(nullable: true),
                    Content4 = table.Column<string>(nullable: true),
                    Content5 = table.Column<string>(nullable: true),
                    Content6 = table.Column<string>(nullable: true),
                    Content7 = table.Column<string>(nullable: true),
                    Content8 = table.Column<string>(nullable: true),
                    Content9 = table.Column<string>(nullable: true),
                    Content10 = table.Column<string>(nullable: true),
                    Content11 = table.Column<string>(nullable: true),
                    Content12 = table.Column<string>(nullable: true),
                    Content13 = table.Column<string>(nullable: true),
                    Content14 = table.Column<string>(nullable: true),
                    Content15 = table.Column<string>(nullable: true),
                    Content16 = table.Column<string>(nullable: true),
                    Content17 = table.Column<string>(nullable: true),
                    Content18 = table.Column<string>(nullable: true),
                    Content19 = table.Column<string>(nullable: true),
                    Content20 = table.Column<string>(nullable: true),
                    Content21 = table.Column<string>(nullable: true),
                    Content22 = table.Column<string>(nullable: true),
                    Content23 = table.Column<string>(nullable: true),
                    Content24 = table.Column<string>(nullable: true),
                    Content25 = table.Column<string>(nullable: true),
                    Content26 = table.Column<string>(nullable: true),
                    Content27 = table.Column<string>(nullable: true),
                    Content28 = table.Column<string>(nullable: true),
                    Content29 = table.Column<string>(nullable: true),
                    Content30 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologien", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Technologien");
        }
    }
}
