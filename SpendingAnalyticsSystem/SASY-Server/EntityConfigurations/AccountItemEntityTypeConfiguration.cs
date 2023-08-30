using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpendingAnalyticsSystem.Infrastructure.Models;

namespace SpendingAnalyticsSystem.API.EntityConfigurations
{
    public class AccountItemEntityTypeConfiguration: IEntityTypeConfiguration<AccountItem>
    {
        public void Configure(EntityTypeBuilder<AccountItem> builder)
        {
            builder.ToTable("AccountItem");

            builder.Property(ai => ai.Id)
                .IsRequired();

            builder.Property(ai => ai.Name);
        }
    }
}
