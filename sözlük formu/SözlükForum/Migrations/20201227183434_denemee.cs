using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class denemee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "kullaniciAdi",
                table: "Admins",
                type: "Varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(20)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "kullaniciAdi",
                table: "Admins",
                type: "Varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(30)",
                oldNullable: true);
        }
    }
}
