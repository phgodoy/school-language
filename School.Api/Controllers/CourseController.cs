using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Api.Models;
using School.Api.Repositories.Interfaces;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseService;

        public CourseController(ICourseRepository courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseModel>>> GetCourses()
        {
            var courses = await _courseService.GetCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CourseModel>> GetCourse(int id)
        {
            var course = await _courseService.GetCourseByIdAsync(id);
            return Ok(course);
        }

        [HttpPost]
        public async Task<ActionResult<CourseModel>> PostCourse(CourseModel courseModel)
        {
            var createdCourse = await _courseService.AddCourseAsync(courseModel);
            return CreatedAtAction(nameof(GetCourse), new { id = createdCourse.ID }, createdCourse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, CourseModel courseModel)
        {
            var updatedCourse = await _courseService.UpdateCourseAsync(id, courseModel);
            return Ok(updatedCourse);
        }
    }
}
