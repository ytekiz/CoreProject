using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
               name: "FK_Blogs_Categorys_CategoryCatagoryID",
               table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryCatagoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CatagoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryCatagoryID",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
