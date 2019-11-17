using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();

        Task<User> GetUserFromIdAsync(int userId);

        Task<bool> UsernameExistsAsync(string username);

        Task<User> AddUserAsync(string username, DateTime created);
    }
}
