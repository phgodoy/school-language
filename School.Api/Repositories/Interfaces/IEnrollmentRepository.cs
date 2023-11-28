using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<List<EnrollmentModel>> GetEnrollmentsAsync();
        Task<EnrollmentModel> GetEnrollmentByIdAsync(int enrollmentId);
        Task<EnrollmentModel> AddEnrollmentAsync(EnrollmentModel enrollment);
        Task<EnrollmentModel> UpdateEnrollmentAsync(int enrollmentId, EnrollmentModel enrollment);
        Task<bool> DeleteEnrollmentAsync(int enrollmentId);
    }
}
