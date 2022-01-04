using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatagoryID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryCatagoryID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryCatagoryID",
                table: "Blogs",
                column: "CategoryCatagoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categorys_CategoryCatagoryID",
                table: "Blogs",
                column: "CategoryCatagoryID",
                principalTable: "Categorys",
                principalColumn: "CatagoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
