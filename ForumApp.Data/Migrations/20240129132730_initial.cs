using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumApp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Post identifier"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Post title"),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Post content")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("4e362a84-3b22-4401-bfae-0854f03af75d"), "Firste sit amet faucibus velit, in facilisis neque. Quisque posuere ex quis tincidunt porta. Curabitur.\r\n\r\n", "First Post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("628dac58-8f86-4ee2-b77d-363141780481"), "Seconde sit amet faucibus velit, in facilisis neque. Quisque posuere ex quis tincidunt porta. Curabitur.\r\n\r\n", "Second Post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { new Guid("946d7890-7dee-47f9-a1f6-36bc2f603fcf"), "Thirde sit amet faucibus velit, in facilisis neque. Quisque posuere ex quis tincidunt porta. Curabitur.\r\n\r\n", "Third Post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
