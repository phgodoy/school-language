using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Api.Models;

public class UserMap : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.ToTable("Users"); 

        builder.HasKey(u => u.ID);

        builder.Property(u => u.FirstName)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(u => u.LastName)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(u => u.DateOfBirth)
            .IsRequired();

        builder.Property(u => u.Email)
            .HasMaxLength(255);

        builder.Property(u => u.Phone)
            .HasMaxLength(20);

        builder.Property(u => u.UserRole).IsRequired();

        builder.Property(u => u.Status).IsRequired();

        builder.Property(u => u.PasswordHash)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasIndex(u => u.Email).IsUnique();

        builder.HasIndex(u => u.ID).IsUnique();

        // Relacionamentos, se houver
        // Exemplo: builder.HasMany(u => u.Courses).WithOne().HasForeignKey("UserID");

    }
}
