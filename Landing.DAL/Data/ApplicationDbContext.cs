using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VivaStore.DAL.Models;

namespace VivaStore.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            var userRoleId = Guid.NewGuid().ToString();
            var adminRoleId = Guid.NewGuid().ToString();
            var superAdminRoleId = Guid.NewGuid().ToString();
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" },
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = superAdminRoleId, Name = "SuperAdmin", NormalizedName = "SUPERADMIN" }
                );

            var hasher = new PasswordHasher<ApplicationUser>();
            var admin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@outlook.com",
                NormalizedUserName = "ADMIN@OUTLOOK.COM",
                Email = "admin@outlook.com",
                NormalizedEmail = "ADMIN@OUTLOOK.COM",
                EmailConfirmed = true
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Amjad123//");
            var superAdmin = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "superadmin@outlook.com",
                NormalizedUserName = "SUPERADMIN@OUTLOOK.COM",
                Email = "superadmin@outlook.com",
                NormalizedEmail = "SUPERADMIN@OUTLOOK.COM",
                EmailConfirmed = true
            };
            superAdmin.PasswordHash = hasher.HashPassword(superAdmin, "Amjad123//");
            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user@outlook.sa",
                NormalizedUserName = "USER@OUTLOOK.SA",
                Email = "user@outlook.sa",
                NormalizedEmail = "USER@OUTLOOK.SA",
                EmailConfirmed = true
            };
            user.PasswordHash = hasher.HashPassword(user, "Amjad123//");

            builder.Entity<ApplicationUser>().HasData(user, admin, superAdmin);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = userRoleId, UserId = user.Id },
                new IdentityUserRole<string> { RoleId = adminRoleId, UserId = admin.Id },
                new IdentityUserRole<string> { RoleId = superAdminRoleId, UserId = superAdmin.Id }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<SliderHome> SliderHome { get; set; }
    }
}
