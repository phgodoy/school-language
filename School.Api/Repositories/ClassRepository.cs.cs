using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public Task<ClassModel> AddClassAsync(ClassModel classModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClassAsync(int classId)
        {
            throw new NotImplementedException();
        }

        public Task<ClassModel> GetClassByIdAsync(int classId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClassModel>> GetClassesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClassModel> UpdateClassAsync(int classId, ClassModel classModel)
        {
            throw new NotImplementedException();
        }

    }

}