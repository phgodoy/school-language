using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface IClassRepository
    {
        Task<List<ClassModel>> GetClassesAsync();
        Task<ClassModel> GetClassByIdAsync(int classId);
        Task<ClassModel> AddClassAsync(ClassModel classModel);
        Task<ClassModel> UpdateClassAsync(int classId, ClassModel classModel);
        Task<bool> DeleteClassAsync(int classId);
    }
}
