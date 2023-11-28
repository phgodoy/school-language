using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Api.Models;

public class EnrollmentMap : IEntityTypeConfiguration<EnrollmentModel>
{
    public void Configure(EntityTypeBuilder<EnrollmentModel> builder)
    {
        // Nome da tabela no banco de dados
        builder.ToTable("Enrollments");

        // Chave primária
        builder.HasKey(e => e.ID);

        // Mapeamento das colunas
        builder.Property(e => e.ID).HasColumnName("ID");
        builder.Property(e => e.UserID).HasColumnName("UserID");
        builder.Property(e => e.ClassID).HasColumnName("ClassID");
        builder.Property(e => e.EnrollmentDate).HasColumnName("EnrollmentDate");
        builder.Property(e => e.PaymentStatus).HasColumnName("PaymentStatus");

        // Chave estrangeira para a tabela Users
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        // Chave estrangeira para a tabela Classes
        builder.HasOne(e => e.Class)
            .WithMany()
            .HasForeignKey(e => e.ClassID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
