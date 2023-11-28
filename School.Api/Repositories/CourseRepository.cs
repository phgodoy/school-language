using School.Api.Models;
using School.Api.Repositories.Interfaces;

namespace School.Api.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Task<CourseModel> AddCourseAsync(CourseModel courseModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCourseAsync(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<CourseModel> GetCourseByIdAsync(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseModel>> GetCoursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CourseModel> UpdateCourseAsync(int courseId, CourseModel courseModel)
        {
            throw new NotImplementedException();
        }
    }
}
