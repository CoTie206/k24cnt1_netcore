using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HctNetCoreLab12_EF.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HctCategory",
                columns: table => new
                {
                    HctID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HctName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HctStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    HctCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HctCategory", x => x.HctID);
                });

            migrationBuilder.CreateTable(
                name: "HctProduct",
                columns: table => new
                {
                    HctID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HctName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HctImage = table.Column<string>(type: "varchar(150)", nullable: false),
                    HctPrice = table.Column<float>(type: "real", nullable: false),
                    HctSalePrice = table.Column<float>(type: "real", nullable: false),
                    HctStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    HctDescription = table.Column<string>(type: "ntext", maxLength: 1000, nullable: false),
                    HctCategoryID = table.Column<int>(type: "int", nullable: false),
                    HctCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HctProduct", x => x.HctID);
                    table.ForeignKey(
                        name: "FK_HctProduct_HctCategory_HctCategoryID",
                        column: x => x.HctCategoryID,
                        principalTable: "HctCategory",
                        principalColumn: "HctID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HctProduct_HctCategoryID",
                table: "HctProduct",
                column: "HctCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HctProduct");

            migrationBuilder.DropTable(
                name: "HctCategory");
        }
    }
}
