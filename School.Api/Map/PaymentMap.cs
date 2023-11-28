using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Api.Models;

public class PaymentMap : IEntityTypeConfiguration<PaymentModel>
{
    public void Configure(EntityTypeBuilder<PaymentModel> builder)
    {
        builder.ToTable("Payments"); // Nome da tabela no banco de dados
        builder.HasKey(p => p.ID); // Chave primária

        builder.Property(p => p.ID).HasColumnName("ID");
        builder.Property(p => p.UserID).HasColumnName("UserID");
        builder.Property(p => p.PaymentDate).HasColumnName("PaymentDate");
        builder.Property(p => p.PaymentAmount).HasColumnName("PaymentAmount");
        builder.Property(p => p.PaymentMethod).HasColumnName("PaymentMethod");
        builder.Property(p => p.RelatedEnrollmentID).HasColumnName("RelatedEnrollmentID");

        builder.HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.RelatedEnrollment)
            .WithMany()
            .HasForeignKey(p => p.RelatedEnrollmentID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
