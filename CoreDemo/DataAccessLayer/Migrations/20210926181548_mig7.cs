using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatagoryID",
                table: "Blog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryCatagoryID",
                table: "Blog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryCatagoryID",
                table: "Blog",
                column: "CategoryCatagoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Categorys_CategoryCatagoryID",
                table: "Blog",
                column: "CategoryCatagoryID",
                principalTable: "Categorys",
                principalColumn: "CatagoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
