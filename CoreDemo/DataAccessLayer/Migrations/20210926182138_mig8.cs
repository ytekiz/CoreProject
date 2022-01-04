using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categorys_CategoryCatagoryID",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
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

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blog_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "Blog",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
