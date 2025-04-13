
using FlipkartWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FlipkartWeb
{
    public class AppDBContext :DbContext
    {
        public DbSet<AuthendModel> authendModels { get; set; }

        public DbSet<LaptopModel> laptopModels { get; set; }

        public DbSet<MobileModel> mobileModels { get; set; }

        public DbSet<Orderplaced> orderPlaced { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

    }
}
