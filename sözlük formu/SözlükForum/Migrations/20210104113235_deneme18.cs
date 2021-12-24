using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoruBegens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kulsor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullaniciid = table.Column<int>(type: "int", nullable: true),
                    forumSoruId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoruBegens", x => x.id);
                    table.ForeignKey(
                        name: "FK_SoruBegens_ForumSorus_forumSoruId",
                        column: x => x.forumSoruId,
                        principalTable: "ForumSorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SoruBegens_Kullanicis_kullaniciid",
                        column: x => x.kullaniciid,
                        principalTable: "Kullanicis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoruBegens_forumSoruId",
                table: "SoruBegens",
                column: "forumSoruId");

            migrationBuilder.CreateIndex(
                name: "IX_SoruBegens_kullaniciid",
                table: "SoruBegens",
                column: "kullaniciid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoruBegens");
        }
    }
}
