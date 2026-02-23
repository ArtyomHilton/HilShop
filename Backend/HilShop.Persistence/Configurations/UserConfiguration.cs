using HilShop.Domain.Entities.User;
using HilShop.Domain.Entities.User.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HilShop.Persistence.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(
                x => x.Value,
                x => new UserId(x));

        builder.Property(x => x.Email)
            .HasConversion(
                x => x.Value, 
                x => new EmailAddress(x))
            .IsRequired();

        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.Property(x => x.PasswordHash)
            .HasConversion(
                x => x.Value,
                x => new PasswordHash(x))
            .IsRequired();
    }
}
