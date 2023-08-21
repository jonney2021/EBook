using Book.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Mystery", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Fantasy", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Romance", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Thriller", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Horror", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Adventure", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Historical Fiction", DisplayOrder = 10 },
                new Category { Id = 11, Name = "Science", DisplayOrder = 11 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Harry Potter",
                    Author = "J.K. Rowling",
                    Description = "The first book in the Harry Potter series, following the young wizard Harry as he embarks on a magical journey.",
                    ISBN = "9780439554930",
                    ListPrice = 20,
                    Price = 15,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 2, // Fantasy
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "The Da Vinci Code",
                    Author = "Dan Brown",
                    Description = "A thriller novel that combines art, history, and religion, following Robert Langdon as he unravels a mystery.",
                    ISBN = "9780385504201",
                    ListPrice = 25,
                    Price = 20,
                    Price50 = 18,
                    Price100 = 15,
                    CategoryId = 7, // Thriller
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Description = "A classic romance novel that explores societal norms and love through the story of Elizabeth Bennet and Mr. Darcy.",
                    ISBN = "9780141439518",
                    ListPrice = 15,
                    Price = 12,
                    Price50 = 10,
                    Price100 = 8,
                    CategoryId = 6, // Romance
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    Description = "The first book in The Lord of the Rings trilogy, following the journey of Frodo Baggins to destroy the One Ring.",
                    ISBN = "9780618346257",
                    ListPrice = 18,
                    Price = 14,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 5, // Fantasy
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Gone Girl",
                    Author = "Gillian Flynn",
                    Description = "A psychological thriller that delves into the complexities of a marriage and the mystery behind a woman's disappearance.",
                    ISBN = "9780307588364",
                    ListPrice = 17,
                    Price = 14,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 4, // Mystery
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Ender's Game",
                    Author = "Orson Scott Card",
                    Description = "A science fiction novel that follows the story of Ender Wiggin, a young boy trained in a military academy to fight against an alien species.",
                    ISBN = "9780812550702",
                    ListPrice = 12,
                    Price = 10,
                    Price50 = 8,
                    Price100 = 7,
                    CategoryId = 11, // Science
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Title = "The Shining",
                    Author = "Stephen King",
                    Description = "A horror novel that follows a family's terrifying experiences in an isolated hotel during the winter.",
                    ISBN = "9780385121675",
                    ListPrice = 22,
                    Price = 18,
                    Price50 = 15,
                    Price100 = 12,
                    CategoryId = 8, // Horror
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "The Martian",
                    Author = "Andy Weir",
                    Description = "A science fiction novel about an astronaut's struggle to survive on Mars after being left behind by his crew.",
                    ISBN = "9780553418026",
                    ListPrice = 16,
                    Price = 14,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 11, // Science
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "The Girl on the Train",
                    Author = "Paula Hawkins",
                    Description = "A psychological thriller that revolves around the lives of three women and a mystery that unfolds through their perspectives.",
                    ISBN = "9781594634024",
                    ListPrice = 19,
                    Price = 15,
                    Price50 = 13,
                    Price100 = 11,
                    CategoryId = 4, // Mystery
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Description = "A fantasy adventure novel that follows Bilbo Baggins on his journey to help a group of dwarves reclaim their homeland.",
                    ISBN = "9780547928227",
                    ListPrice = 21,
                    Price = 18,
                    Price50 = 16,
                    Price100 = 14,
                    CategoryId = 5, // Fantasy
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "Tech City",
                    PostalCode = "A1B 1C1",
                    Province = "ON",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "A1B 1C1",
                    Province = "QC",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "A1B 1C1",
                    Province = "BC",
                    PhoneNumber = "1113335555"
                }
                );
        }
    }
}
