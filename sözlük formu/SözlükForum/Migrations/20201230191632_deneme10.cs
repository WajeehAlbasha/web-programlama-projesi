using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SözlükForum.Migrations
{
    public partial class deneme10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icerik = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Zaman = table.Column<DateTime>(type: "datetime2", nullable: false),
                    forumsoruId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorums_ForumSorus_forumsoruId",
                        column: x => x.forumsoruId,
                        principalTable: "ForumSorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_forumsoruId",
                table: "Yorums",
                column: "forumsoruId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yorums");
        }
    }
}
