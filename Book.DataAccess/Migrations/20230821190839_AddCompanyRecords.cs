using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "Province", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Tech City", "Tech Solution", "6669990000", "A1B 1C1", "ON", "123 Tech St" },
                    { 2, "Vid City", "Vivid Books", "7779990000", "A1B 1C1", "QC", "999 Vid St" },
                    { 3, "Lala land", "Readers Club", "1113335555", "A1B 1C1", "BC", "999 Main St" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
