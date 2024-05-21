using System.Collections.Generic;
using System.Threading.Tasks;
using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    /// <summary>
    /// Manages course data.
    /// </summary>
    public interface ICourseRepository
    {
        /// <summary>
        /// Gets all courses.
        /// </summary>
        /// <returns>A list of courses.</returns>
        Task<List<CourseModel>> GetCoursesAsync();

        /// <summary>
        /// Gets a course by ID.
        /// </summary>
        /// <param name="courseId">The course ID.</param>
        /// <returns>The course.</returns>
        Task<CourseModel> GetCourseByIdAsync(int courseId);

        /// <summary>
        /// Adds a new course.
        /// </summary>
        /// <param name="courseModel">The course to add.</param>
        /// <returns>The added course.</returns>
        Task<CourseModel> AddCourseAsync(CourseModel courseModel);

        /// <summary>
        /// Updates a course.
        /// </summary>
        /// <param name="courseId">The course ID.</param>
        /// <param name="courseModel">The course details.</param>
        /// <returns>The updated course.</returns>
        Task<CourseModel> UpdateCourseAsync(int courseId, CourseModel courseModel);
    }
}
