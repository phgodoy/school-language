using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel> AddUser(UserModel user);
        Task<List<UserModel>> GetAllUsers();
        Task<UserModel> GetUserById(int userId);
        Task<UserModel> UpdateUser(int userId, UserModel userData);

        /// <summary>
        /// this metodo enable a user 
        /// </summary>
        /// <param name="userId">User Id use to search and enable</param>
        /// <returns>user enable</returns>
        Task<UserModel> EnableUser(int userId);
    }
}