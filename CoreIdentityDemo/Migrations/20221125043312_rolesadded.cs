using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreIdentityDemo.Migrations
{
    public partial class rolesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5f13699-3e8c-4c10-9abe-0362bc316b1f", "669beee3-500e-4c7b-aa6c-3bfb45d2de48", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4f42a2e-1d83-4020-b793-10a16b6c5e6d", "aad6893b-25f1-4092-9da2-c2fb407de426", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5f13699-3e8c-4c10-9abe-0362bc316b1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4f42a2e-1d83-4020-b793-10a16b6c5e6d");
        }
    }
}
