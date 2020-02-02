using Microsoft.EntityFrameworkCore.Migrations;

namespace CancerInstApi.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Palindromes");

            migrationBuilder.AlterColumn<string>(
                name: "Phrase",
                table: "Palindromes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phrase",
                table: "Palindromes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Palindromes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
