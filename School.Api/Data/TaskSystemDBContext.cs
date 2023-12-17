using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School.Api.Models; // Certifique-se de adicionar o namespace correto

public class TaskSystemDBContext :DbContext
{
    public TaskSystemDBContext(DbContextOptions<TaskSystemDBContext> options)
        : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; }
    public DbSet<LanguageModel> Languages { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<PaymentModel> Payments { get; set; }
    public DbSet<ClassModel>  Classes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
