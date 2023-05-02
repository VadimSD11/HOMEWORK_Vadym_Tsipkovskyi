using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Data.Identity;

namespace WebApplication5.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationIdentityUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationIdentityUser> builder)
        {
            builder.Property(u => u.Name).HasMaxLength(100);

        }
    }
}