using Microsoft.EntityFrameworkCore.Migrations;

namespace ThirdTask_For_BackEnd___20._04._2023.Migrations
{
    public partial class DataTablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureForHome",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureForHome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureForService",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureForService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureForHome");

            migrationBuilder.DropTable(
                name: "FeatureForService");

            migrationBuilder.DropTable(
                name: "Slider");
        }
    }
}
