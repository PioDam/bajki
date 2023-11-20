using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bajki.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Miniature = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph1 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph2 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph3 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph4 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph5 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph6 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph7 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph8 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Paragraph9 = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tales");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
