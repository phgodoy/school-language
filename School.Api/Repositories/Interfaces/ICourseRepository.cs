using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<CourseModel>> GetCoursesAsync();
        Task<CourseModel> GetCourseByIdAsync(int courseId);
        Task<CourseModel> AddCourseAsync(CourseModel courseModel);
        Task<CourseModel> UpdateCourseAsync(int courseId, CourseModel courseModel);
        Task<bool> DeleteCourseAsync(int courseId);
    }
}
