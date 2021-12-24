using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "kullanıcıAd",
                table: "Kullanicis",
                type: "Varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "kullanıcıAd",
                table: "Kullanicis",
                type: "Varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(40)");
        }
    }
}
