using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Data.Migrations
{
    public partial class TestClassStructure002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestAppFormGens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommQ01 = table.Column<string>(nullable: true),
                    SpecQ11 = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    SpecQ12 = table.Column<string>(nullable: true),
                    SpecQ13 = table.Column<string>(nullable: true),
                    SpecQ21 = table.Column<string>(nullable: true),
                    SpecQ22 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestAppFormGens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestAppFormGens");
        }
    }
}
