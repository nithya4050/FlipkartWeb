using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlipkartWeb.Migrations
{
    /// <inheritdoc />
    public partial class jsmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authendModels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emailid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authendModels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "laptopModels",
                columns: table => new
                {
                    ModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstalledRAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SystemType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profilepicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laptopModels", x => x.ModelID);
                });

            migrationBuilder.CreateTable(
                name: "mobileModels",
                columns: table => new
                {
                    MobileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobilemodel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mobileModels", x => x.MobileID);
                });

            migrationBuilder.CreateTable(
                name: "orderPlaced",
                columns: table => new
                {
                    Oid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderPlaced", x => x.Oid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authendModels");

            migrationBuilder.DropTable(
                name: "laptopModels");

            migrationBuilder.DropTable(
                name: "mobileModels");

            migrationBuilder.DropTable(
                name: "orderPlaced");
        }
    }
}
