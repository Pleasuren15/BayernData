using Microsoft.EntityFrameworkCore.Migrations;

namespace BayernData.Migrations.AppDb
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffKitNumber = table.Column<int>(type: "int", nullable: false),
                    StaffImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffPosition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
