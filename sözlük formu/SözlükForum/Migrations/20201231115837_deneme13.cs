using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorums_Kullanicis_kullaniciid",
                table: "Yorums");

            migrationBuilder.AlterColumn<int>(
                name: "kullaniciid",
                table: "Yorums",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "katego",
                table: "ForumSorus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorums_Kullanicis_kullaniciid",
                table: "Yorums",
                column: "kullaniciid",
                principalTable: "Kullanicis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorums_Kullanicis_kullaniciid",
                table: "Yorums");

            migrationBuilder.DropColumn(
                name: "katego",
                table: "ForumSorus");

            migrationBuilder.AlterColumn<int>(
                name: "kullaniciid",
                table: "Yorums",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorums_Kullanicis_kullaniciid",
                table: "Yorums",
                column: "kullaniciid",
                principalTable: "Kullanicis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
