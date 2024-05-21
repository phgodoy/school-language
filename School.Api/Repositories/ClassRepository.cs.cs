using Microsoft.EntityFrameworkCore;
using School.Api.Models;
using School.Api.Repositories.Interfaces;

namespace School.Api.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly TaskSystemDBContext _taskSystemDBContext;

        public ClassRepository(TaskSystemDBContext taskSystemDBContext)
        {
            _taskSystemDBContext = taskSystemDBContext;
        }

        /// <inheritdoc />
        public async Task<ClassModel> AddClassAsync(ClassModel classModel)
        {
            await _taskSystemDBContext.Classes.AddAsync(classModel);
            await _taskSystemDBContext.SaveChangesAsync();

            return classModel;
        }

        /// <inheritdoc />
        public async Task<ClassModel> GetClassByIdAsync(int classId)
        {
            return await _taskSystemDBContext.Classes.FirstOrDefaultAsync(x => x.ID == classId);
        }

        public Task<List<ClassModel>> GetClassesAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ClassModel> UpdateClassAsync(int classId, ClassModel classData)
        {
            ClassModel classModel = await GetClassByIdAsync(classId);

            if (classModel == null)
            {
                throw new Exception("Usuário não foi encontrado");
            }
            _taskSystemDBContext.Entry(classModel).CurrentValues.SetValues(classData);

            await _taskSystemDBContext.SaveChangesAsync();

            return classModel;
        }
    }
}
