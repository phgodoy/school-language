//using Microsoft.AspNetCore.Mvc;
//using School.Api.Models;
//using School.Api.Repositories.Interfaces;

//[Route("api/[controller]")]
//[ApiController]
//public class StudentsController : ControllerBase
//{
//    private readonly IStudentRepository _studentService;

//    public StudentsController(IStudentRepository studentService)
//    {
//        _studentService = studentService;
//    }


//    [HttpGet]
//    public async Task<ActionResult<List<StudentModel>>> GetStudents()
//    {
//        List<StudentModel> Students =  await _studentService.GetStudentsAsync();

//        return Ok(Students);
//    }

//    //// GET: api/Students/5
//    [HttpGet("{id}")]
//    public async Task<ActionResult<StudentModel>> GetStudent(int id)
//    {
//        var Students = await _studentService.GetStudentByIdAsync(id);

//        return Ok(Students);
//    }

//    //// POST: api/Students
//    [HttpPost]
//    public async Task<ActionResult<StudentModel>> PostStudent(StudentModel student)
//    {
//        StudentModel Student = await  _studentService.AddStudentAsync(student);
       
//        return Ok(Student);
//    }

//    //// PUT: api/Students/5
//    [HttpPut("{id}")]
//    public async Task<IActionResult> PutStudent(int id, StudentModel student)
//    {
//        var Students = await _studentService.UpdateStudentAsync(id, student);

//        return Ok(Students);

//    }

//    //// DELETE: api/Students/5
//    [HttpDelete("{id}")]
//    public async Task<IActionResult> DeleteStudent(int id)
//    {
//        var student = await _studentService.DeleteStudentAsync(id);

//        return Ok(student);
//    }

//}
