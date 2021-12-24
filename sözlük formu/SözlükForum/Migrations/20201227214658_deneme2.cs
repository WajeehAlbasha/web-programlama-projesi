using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumSoru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soru = table.Column<string>(type: "Varchar(500)", nullable: true),
                    kullaniciid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumSoru", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumSoru_Kullanicis_kullaniciid",
                        column: x => x.kullaniciid,
                        principalTable: "Kullanicis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumSoru_kullaniciid",
                table: "ForumSoru",
                column: "kullaniciid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumSoru");
        }
    }
}
