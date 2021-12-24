using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "kullanıcıAd",
                table: "Kullanicis",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "soru",
                table: "ForumSorus",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "icerik",
                table: "ForumSorus",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(1000)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "kullanıcıAd",
                table: "Kullanicis",
                type: "Varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "soru",
                table: "ForumSorus",
                type: "Varchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "icerik",
                table: "ForumSorus",
                type: "Varchar(1000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
