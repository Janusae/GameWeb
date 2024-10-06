using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestProject.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Context1_h2",
                table: "IndexInfo",
                newName: "Context_Header");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Context_Header",
                table: "IndexInfo",
                newName: "Context1_h2");
        }
    }
}
