using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFD2.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "time",
                table: "Posts",
                type: "time",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TimeSpan",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "time",
                table: "Posts",
                type: "TimeSpan",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);
        }
    }
}
