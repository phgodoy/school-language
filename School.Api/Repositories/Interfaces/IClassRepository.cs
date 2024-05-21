using System.Collections.Generic;
using System.Threading.Tasks;
using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    /// <summary>
    /// Manages class data.
    /// </summary>
    public interface IClassRepository
    {
        /// <summary>
        /// Gets all classes.
        /// </summary>
        /// <returns>A list of classes.</returns>
        Task<List<ClassModel>> GetClassesAsync();

        /// <summary>
        /// Gets a class by ID.
        /// </summary>
        /// <param name="classId">The class ID.</param>
        /// <returns>The class.</returns>
        Task<ClassModel> GetClassByIdAsync(int classId);

        /// <summary>
        /// Adds a new class.
        /// </summary>
        /// <param name="classModel">The class to add.</param>
        /// <returns>The added class.</returns>
        Task<ClassModel> AddClassAsync(ClassModel classModel);

        /// <summary>
        /// Updates a class.
        /// </summary>
        /// <param name="classId">The class ID.</param>
        /// <param name="classModel">The class details.</param>
        /// <returns>The updated class.</returns>
        Task<ClassModel> UpdateClassAsync(int classId, ClassModel classModel);
    }
}
