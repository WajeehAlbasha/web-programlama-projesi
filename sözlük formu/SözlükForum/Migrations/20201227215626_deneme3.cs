using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumSoru_Kullanicis_kullaniciid",
                table: "ForumSoru");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumSoru",
                table: "ForumSoru");

            migrationBuilder.RenameTable(
                name: "ForumSoru",
                newName: "ForumSorus");

            migrationBuilder.RenameIndex(
                name: "IX_ForumSoru_kullaniciid",
                table: "ForumSorus",
                newName: "IX_ForumSorus_kullaniciid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumSorus",
                table: "ForumSorus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumSorus_Kullanicis_kullaniciid",
                table: "ForumSorus",
                column: "kullaniciid",
                principalTable: "Kullanicis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumSorus_Kullanicis_kullaniciid",
                table: "ForumSorus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumSorus",
                table: "ForumSorus");

            migrationBuilder.RenameTable(
                name: "ForumSorus",
                newName: "ForumSoru");

            migrationBuilder.RenameIndex(
                name: "IX_ForumSorus_kullaniciid",
                table: "ForumSoru",
                newName: "IX_ForumSoru_kullaniciid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumSoru",
                table: "ForumSoru",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumSoru_Kullanicis_kullaniciid",
                table: "ForumSoru",
                column: "kullaniciid",
                principalTable: "Kullanicis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
