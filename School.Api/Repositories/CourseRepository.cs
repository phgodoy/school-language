using School.Api.Models;
using School.Api.Repositories.Interfaces;
using System.Data.Entity;

namespace School.Api.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly TaskSystemDBContext _taskSystemDBContext;

        public CourseRepository(TaskSystemDBContext taskSystemDBContext)
        {
            _taskSystemDBContext = taskSystemDBContext;
        }

        /// <inheritdoc />
        public async Task<CourseModel> AddCourseAsync(CourseModel course)
        {
            await _taskSystemDBContext.Courses.AddAsync(course);
            await _taskSystemDBContext.SaveChangesAsync();

            return course;
        }

        /// <inheritdoc />
        public async Task<CourseModel> GetCourseByIdAsync(int courseId)
        {
            return await _taskSystemDBContext.Courses.FirstOrDefaultAsync(x => x.ID == courseId);
        }

        /// <inheritdoc />
        public async Task<List<CourseModel>> GetCoursesAsync()
        {
            return await _taskSystemDBContext.Courses.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<CourseModel> UpdateCourseAsync(int courseId, CourseModel courseData)
        {
            CourseModel course = await GetCourseByIdAsync(courseId);

            if (course == null)
            {
                throw new Exception("Usuário não foi encontrado");
            }
            _taskSystemDBContext.Entry(course).CurrentValues.SetValues(courseData);

            await _taskSystemDBContext.SaveChangesAsync();

            return course;
        }
    }
}
