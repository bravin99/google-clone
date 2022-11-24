using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleClone.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToResultsObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GoogleSets",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "GoogleSets");
        }
    }
}
