using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "kullaniciid",
                table: "Yorums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_kullaniciid",
                table: "Yorums",
                column: "kullaniciid");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorums_Kullanicis_kullaniciid",
                table: "Yorums",
                column: "kullaniciid",
                principalTable: "Kullanicis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorums_Kullanicis_kullaniciid",
                table: "Yorums");

            migrationBuilder.DropIndex(
                name: "IX_Yorums_kullaniciid",
                table: "Yorums");

            migrationBuilder.DropColumn(
                name: "kullaniciid",
                table: "Yorums");
        }
    }
}
