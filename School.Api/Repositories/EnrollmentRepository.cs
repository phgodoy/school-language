using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Api.Models;
using School.Api.Repositories.Interfaces;

namespace School.Api.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly TaskSystemDBContext _taskSystemDBContext;

        public EnrollmentRepository(TaskSystemDBContext taskSystemDBContext)
        {
            _taskSystemDBContext = taskSystemDBContext;
        }

        public async Task<EnrollmentModel> AddEnrollmentAsync(EnrollmentModel enrollment)
        {
            await _taskSystemDBContext.Enrollments.AddAsync(enrollment);
            await _taskSystemDBContext.SaveChangesAsync();
            return enrollment;
        }

        public async Task<bool> DeleteEnrollmentAsync(int enrollmentId)
        {
            EnrollmentModel enrollmentModel = await GetEnrollmentByIdAsync(enrollmentId);

            if (enrollmentModel == null)
            {
                throw new Exception("A matrícula não foi encontrada");
            }

            _taskSystemDBContext.Enrollments.Remove(enrollmentModel);
            await _taskSystemDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<EnrollmentModel> GetEnrollmentByIdAsync(int enrollmentId)
        {
            return await _taskSystemDBContext.Enrollments.FirstOrDefaultAsync(x => x.ID == enrollmentId);
        }

        public async Task<List<EnrollmentModel>> GetEnrollmentsAsync()
        {
            return await _taskSystemDBContext.Enrollments.ToListAsync();
        }

        public async Task<EnrollmentModel> UpdateEnrollmentAsync(int enrollmentId, EnrollmentModel enrollment)
        {
            EnrollmentModel enrollmentModel = await GetEnrollmentByIdAsync(enrollmentId);

            if (enrollmentModel == null)
            {
                throw new Exception("A matrícula não foi encontrada");
            }

            // Atualize as propriedades da matrícula com os valores fornecidos
            enrollmentModel.UserID = enrollment.UserID;
            enrollmentModel.ClassID = enrollment.ClassID;
            enrollmentModel.EnrollmentDate = enrollment.EnrollmentDate;
            enrollmentModel.PaymentStatus = enrollment.PaymentStatus;

            _taskSystemDBContext.Enrollments.Update(enrollmentModel);
            await _taskSystemDBContext.SaveChangesAsync();

            return enrollmentModel;
        }
    }
}