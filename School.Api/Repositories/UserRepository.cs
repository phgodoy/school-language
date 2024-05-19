using School.Api.Models;
using School.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace School.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TaskSystemDBContext _taskSystemDBContext;
        public UserRepository(TaskSystemDBContext taskSystemDBContext)
        {
            _taskSystemDBContext = taskSystemDBContext;
        }

        public async Task<UserModel> AddUser(UserModel user)
        {
            await _taskSystemDBContext.Users.AddAsync(user);
            await _taskSystemDBContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _taskSystemDBContext.Users.ToListAsync();
        }

        public async Task<UserModel> GetUserById(int userId)
        {
            return await _taskSystemDBContext.Users.FirstOrDefaultAsync(x => x.ID == userId);
        }

        public async Task<UserModel> UpdateUser(int userId, UserModel userData)
        {
            UserModel user = await GetUserById(userId);

            if (user == null)
            {
                throw new Exception("Usuário não foi encontrado");
            }
            _taskSystemDBContext.Entry(user).CurrentValues.SetValues(userData);

            await _taskSystemDBContext.SaveChangesAsync();

            return user;
        }

        public async Task<UserModel> EnableUser(int userId)
        {
            try
            {
                UserModel user = await GetUserById(userId);

                if (user != null)
                {
                    user.Status = 1; // Supondo que 1 represente o status de usuário habilitado, ajuste conforme necessário

                    _taskSystemDBContext.Entry(user).State = EntityState.Modified;

                    await _taskSystemDBContext.SaveChangesAsync();

                }
                return user;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao  habilidar o ususario:",ex);
            }
        }

    }
}