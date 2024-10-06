using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestProject.Migrations
{
    /// <inheritdoc />
    public partial class add3Columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasOffer",
                table: "IndexInfo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Offer",
                table: "IndexInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "IndexInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasOffer",
                table: "IndexInfo");

            migrationBuilder.DropColumn(
                name: "Offer",
                table: "IndexInfo");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "IndexInfo");
        }
    }
}
