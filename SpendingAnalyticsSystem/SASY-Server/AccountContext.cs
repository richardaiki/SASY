using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SpendingAnalyticsSystem.API.EntityConfigurations;
using SpendingAnalyticsSystem.Infrastructure.Models;

namespace SpendingAnalyticsSystem.API
{
    public class AccountContext: DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        { }

        public DbSet<AccountItem> AccountItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AccountItemEntityTypeConfiguration());
        }
    }

    public class AccountContextDesignFactory : IDesignTimeDbContextFactory<AccountContext>
    {
        public AccountContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AccountContext>()
                .UseSqlServer("Server=.;Initial Catalog=Home.Sasy.db;Integrated Security=true"); // TODO Design Time variable?

            return new AccountContext(optionsBuilder.Options);
        }
    }
}
