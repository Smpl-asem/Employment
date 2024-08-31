using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employment.Migrations
{
    /// <inheritdoc />
    public partial class jobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GovahiMotor",
                table: "Users_tbl",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Users_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Jobs_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs_tbl", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_tbl_departmentId",
                table: "Users_tbl",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_tbl_Jobs_tbl_departmentId",
                table: "Users_tbl",
                column: "departmentId",
                principalTable: "Jobs_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_tbl_Jobs_tbl_departmentId",
                table: "Users_tbl");

            migrationBuilder.DropTable(
                name: "Jobs_tbl");

            migrationBuilder.DropIndex(
                name: "IX_Users_tbl_departmentId",
                table: "Users_tbl");

            migrationBuilder.DropColumn(
                name: "GovahiMotor",
                table: "Users_tbl");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Users_tbl");
        }
    }
}
