using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpendingAnalyticsSystem.API.Models;

namespace SpendingAnalyticsSystem.API.EntityConfigurations
{
    public class AccountItemEntityTypeConfiguration: IEntityTypeConfiguration<AccountItem>
    {
        public void Configure(EntityTypeBuilder<AccountItem> builder)
        {
            builder.ToTable("AccountItem");

            builder.Property(ai => ai.Id)
                .IsRequired();

            builder.Property(ai => ai.Name)
                .IsRequired();

            builder.Property(ai => ai.Number)
                .IsRequired();

            builder.Property(ai => ai.Date)
                .IsRequired();

            builder.Property(ai => ai.Account)
                .IsRequired();

            builder.Property(ai => ai.Amount)
                .HasColumnType("decimal(18,4)")
                .IsRequired();

            builder.Property(ai => ai.Subcategory)
                .IsRequired();

            builder.Property(ai => ai.Memo)
                .IsRequired();

            builder.Property(ai => ai.Balance)
                .HasPrecision(10)
                .HasColumnType("decimal(18,4)")
                .IsRequired();

        }
    }
}
