using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sifre",
                table: "Kullanicis",
                type: "Varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "kullanıcıAd",
                table: "Kullanicis",
                type: "Varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "soru",
                table: "ForumSorus",
                type: "Varchar(500)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(500)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sifre",
                table: "Admins",
                type: "Varchar(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "kullaniciAdi",
                table: "Admins",
                type: "Varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sifre",
                table: "Kullanicis",
                type: "Varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "kullanıcıAd",
                table: "Kullanicis",
                type: "Varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "soru",
                table: "ForumSorus",
                type: "Varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "sifre",
                table: "Admins",
                type: "Varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "kullaniciAdi",
                table: "Admins",
                type: "Varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
