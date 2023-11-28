using School.Api.Models;
using School.Api.Repositories.Interfaces;

namespace School.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserModel>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}