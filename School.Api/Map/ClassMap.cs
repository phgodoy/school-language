using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Api.Models;

namespace School.Api.Map
{
    public class ClassMap : IEntityTypeConfiguration<ClassModel>
    {
        public void Configure(EntityTypeBuilder<ClassModel> builder)
        {
            builder.ToTable("Classes");
            builder.HasKey(c => c.ID);

            builder.Property(c => c.ID).HasColumnName("ID");
            builder.Property(c => c.ClassNumber).HasColumnName("ClassNumber");
            builder.Property(c => c.CourseID).HasColumnName("CourseID");
            builder.Property(c => c.Schedule).HasColumnName("Schedule");
            builder.Property(c => c.DayOfWeek).HasColumnName("DayOfWeek");
            builder.Property(c => c.Classroom).HasColumnName("Classroom");
            builder.Property(c => c.StartDate).HasColumnName("StartDate");
            builder.Property(c => c.EndDate).HasColumnName("EndDate");
            builder.Property(c => c.MaxCapacity).HasColumnName("MaxCapacity");

            builder.HasOne(c => c.Course)
                .WithMany(course => course.Classes)
                .HasForeignKey(c => c.CourseID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
