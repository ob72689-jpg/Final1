using Final1.Models;
using Microsoft.EntityFrameworkCore;

namespace Final1.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 
        }
        DbSet<MyInfo>MyInfos{ get; set; } 
        DbSet<FavoriteRed>FavoriteReds{ get; set; }
    }
}
