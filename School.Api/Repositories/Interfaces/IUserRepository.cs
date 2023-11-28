using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetAllUsers();
        Task<UserModel> GetUserById(int userId);
        Task AddUser(UserModel user);
        Task UpdateUser(UserModel user);
        Task DeleteUser(int userId);
    }
}