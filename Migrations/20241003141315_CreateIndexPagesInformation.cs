using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestProject.Migrations
{
    /// <inheritdoc />
    public partial class CreateIndexPagesInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndexInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context1_h6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Context1_h2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Context1_p = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CopyriteText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexInfo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndexInfo");
        }
    }
}
