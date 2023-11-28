//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using School.Api.Models;

//namespace School.Api.Map
//{
//    public class StudentMap : IEntityTypeConfiguration<StudentModel>
//    {
//        public void Configure(EntityTypeBuilder<StudentModel> builder)
//        {
//            builder.ToTable("Students");

//            builder.HasKey(x => x.Id);

//            builder.Property(x => x.FirstName)
//                .IsRequired()
//                .HasMaxLength(255);

//            builder.Property(x => x.Email)
//                .IsRequired()
//                .HasMaxLength(255);

//            builder.Property(x => x.DateOfBirth)
//                .IsRequired();

//            builder.Property(x => x.Address)
//                .HasMaxLength(255);

//            builder.Property(x => x.Phone)
//                .HasMaxLength(20);

//            builder.Property(x => x.EnrollmentDate)
//                .IsRequired();
//        }
//    }
//}