using Final1.Models;
using Microsoft.EntityFrameworkCore;

namespace Final1.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        { 
        }
        public DbSet<MyInfo>MyInfos{ get; set; } 
        public DbSet<FavoriteReds>FavoriteReds{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<MyInfo>().HasData(
                new MyInfo
                {
                    Id = 1,
                    Name = "Aaron O'Brien",
                    Program = "IT",
                    ProgramYear = "Sophmore",
                    FavoriteMajor = "Contemporary Programing",
                    FavoriteElective = "Astronomy"
                }
               
            );

            modelBuilder.Entity<FavoriteReds>().HasData(
                new FavoriteReds
                {
                    Id = 1,
                    Name = "Votto",
                    Position = "First Base",
                    Number = 19,
                    ThrowHand = "Left",
                    BatHand = "Left"
                }

            );
        }
    }
}