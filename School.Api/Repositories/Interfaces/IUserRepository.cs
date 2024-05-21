using System.Collections.Generic;
using System.Threading.Tasks;
using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    /// <summary>
    /// Manages user data.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Adds a new user.
        /// </summary>
        /// <param name="user">The user to add.</param>
        /// <returns>The added user.</returns>
        Task<UserModel> AddUser(UserModel user);

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>A list of users.</returns>
        Task<List<UserModel>> GetAllUsers();

        /// <summary>
        /// Gets a user by ID.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>The user.</returns>
        Task<UserModel> GetUserById(int userId);

        /// <summary>
        /// Updates a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <param name="userData">The user details.</param>
        /// <returns>The updated user.</returns>
        Task<UserModel> UpdateUser(int userId, UserModel userData);

        /// <summary>
        /// Enables a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>The enabled user.</returns>
        Task<UserModel> EnableUser(int userId);
    }
}
