//using School.Api.Models;
//using Microsoft.EntityFrameworkCore;
//using School.Api.Repositories.Interfaces;


//namespace School.Api.Repositories
//{
//    public class StudentRepository : IStudentRepository
//    {
//        private readonly TaskSystemDBContext _taskSystemDBContext;
//        public StudentRepository(TaskSystemDBContext taskSystemDBContext)
//        {
//            _taskSystemDBContext = taskSystemDBContext;
//        }

//        public async Task<StudentModel> AddStudentAsync(StudentModel student)
//        {
//            await _taskSystemDBContext.Students.AddAsync(student);
//            await _taskSystemDBContext.SaveChangesAsync();

//            return student;
//        }

//        public async Task<bool> DeleteStudentAsync(int studentId)
//        {
//            StudentModel studentModel = await GetStudentByIdAsync(studentId);

//            if (studentModel == null)
//            {
//                throw new Exception("USUARIO NAO FOI ENCONTRADO");
//            }
//            _taskSystemDBContext.Students.Remove(studentModel);
//            await _taskSystemDBContext.SaveChangesAsync();
//            return true;

//        }

//        public async Task<StudentModel> GetStudentByIdAsync(int studentId)
//        {
//           return await _taskSystemDBContext.Students.FirstOrDefaultAsync(x => x.Id  == studentId);
//        }
//        public async Task<List<StudentModel>> GetStudentsAsync()
//        {
//            return await _taskSystemDBContext.Students.ToListAsync();
//        }
//        public async Task<StudentModel> UpdateStudentAsync(int studentId, StudentModel student)
//        {
//            StudentModel studentModel = await GetStudentByIdAsync(studentId);

//            if(studentModel == null) {
//                throw new Exception("uSUARIO NAO FOI ENCONTRADO");
//            }

//            studentModel.FirstName = student.FirstName;
//            studentModel.LastName = student.LastName;
//            studentModel.Email = student.Email;

//            _taskSystemDBContext.Students.Update(studentModel);
//            await _taskSystemDBContext.SaveChangesAsync();

//            return studentModel;

//        }
//    }
//}