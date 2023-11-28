using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Api.Models;

namespace School.Api.Map
{
    public class CourseMap : IEntityTypeConfiguration<CourseModel>
    {
        public void Configure(EntityTypeBuilder<CourseModel> builder)
        {
            builder.ToTable("Courses"); // Nome da tabela no banco de dados
            builder.HasKey(c => c.ID); // Chave primária

            builder.Property(c => c.ID).HasColumnName("ID");
            builder.Property(c => c.CourseName).HasColumnName("CourseName");
            builder.Property(c => c.CourseDescription).HasColumnName("CourseDescription");
            builder.Property(c => c.CourseDuration).HasColumnName("CourseDuration");
            builder.Property(c => c.Price).HasColumnName("Price");
            builder.Property(c => c.LeadInstructorNavigationID).HasColumnName("LeadInstructorNavigationID");
            builder.Property(c => c.CourseLanguageID).HasColumnName("CourseLanguageID");

            builder.HasOne(c => c.LeadInstructorNavigationID)
                 .WithMany()
                 .HasForeignKey(usermodel => usermodel.ID)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.CourseLanguageID)
                .WithMany()
                .HasForeignKey(LanguageModel => LanguageModel.ID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Classes)
                .WithOne(classModel => classModel.Course)
                .HasForeignKey(classModel => classModel.CourseID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
