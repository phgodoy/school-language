using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel> AddUser(UserModel user);
        Task<bool> DeleteUser(int userId);
        Task<List<UserModel>> GetAllUsers();
        Task<UserModel> GetUserById(int userId);
        Task<UserModel> UpdateUser(int userId, UserModel userData);
    }
}