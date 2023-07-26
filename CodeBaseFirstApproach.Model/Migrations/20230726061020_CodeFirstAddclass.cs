using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeBaseFirstApproach.Model.Migrations
{
    /// <inheritdoc />
    public partial class CodeFirstAddclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Standard",
                table: "UserRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "UserRegistration");
        }
    }
}
