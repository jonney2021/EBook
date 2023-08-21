using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorynProductTablesToDbnSeedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "SciFi" },
                    { 3, 3, "History" },
                    { 4, 4, "Mystery" },
                    { 5, 5, "Fantasy" },
                    { 6, 6, "Romance" },
                    { 7, 7, "Thriller" },
                    { 8, 8, "Horror" },
                    { 9, 9, "Adventure" },
                    { 10, 10, "Historical Fiction" },
                    { 11, 11, "Science" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", 2, "The first book in the Harry Potter series, following the young wizard Harry as he embarks on a magical journey.", "9780439554930", "", 20.0, 15.0, 10.0, 12.0, "Harry Potter" },
                    { 2, "Dan Brown", 7, "A thriller novel that combines art, history, and religion, following Robert Langdon as he unravels a mystery.", "9780385504201", "", 25.0, 20.0, 15.0, 18.0, "The Da Vinci Code" },
                    { 3, "Jane Austen", 6, "A classic romance novel that explores societal norms and love through the story of Elizabeth Bennet and Mr. Darcy.", "9780141439518", "", 15.0, 12.0, 8.0, 10.0, "Pride and Prejudice" },
                    { 4, "J.R.R. Tolkien", 5, "The first book in The Lord of the Rings trilogy, following the journey of Frodo Baggins to destroy the One Ring.", "9780618346257", "", 18.0, 14.0, 10.0, 12.0, "The Lord of the Rings" },
                    { 5, "Gillian Flynn", 4, "A psychological thriller that delves into the complexities of a marriage and the mystery behind a woman's disappearance.", "9780307588364", "", 17.0, 14.0, 10.0, 12.0, "Gone Girl" },
                    { 6, "Orson Scott Card", 11, "A science fiction novel that follows the story of Ender Wiggin, a young boy trained in a military academy to fight against an alien species.", "9780812550702", "", 12.0, 10.0, 7.0, 8.0, "Ender's Game" },
                    { 7, "Stephen King", 8, "A horror novel that follows a family's terrifying experiences in an isolated hotel during the winter.", "9780385121675", "", 22.0, 18.0, 12.0, 15.0, "The Shining" },
                    { 8, "Andy Weir", 11, "A science fiction novel about an astronaut's struggle to survive on Mars after being left behind by his crew.", "9780553418026", "", 16.0, 14.0, 10.0, 12.0, "The Martian" },
                    { 9, "Paula Hawkins", 4, "A psychological thriller that revolves around the lives of three women and a mystery that unfolds through their perspectives.", "9781594634024", "", 19.0, 15.0, 11.0, 13.0, "The Girl on the Train" },
                    { 10, "J.R.R. Tolkien", 5, "A fantasy adventure novel that follows Bilbo Baggins on his journey to help a group of dwarves reclaim their homeland.", "9780547928227", "", 21.0, 18.0, 14.0, 16.0, "The Hobbit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
