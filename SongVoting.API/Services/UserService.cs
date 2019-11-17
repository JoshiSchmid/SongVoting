using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _databaseContext;

        public UserService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<User> AddUserAsync(string username, DateTime created)
        {
            var user = new User
            {
                Username = username,
                Created = created
            };

            await _databaseContext.Users.AddAsync(user);

            await _databaseContext.SaveChangesAsync();

            return user;
        }

        public Task<User> GetUserFromIdAsync(int userId)
        {
            return _databaseContext.Users.FirstOrDefaultAsync(i => i.Id == userId);
        }

        public Task<List<User>> GetUsersAsync()
        {
            return _databaseContext.Users.ToListAsync();
        }

        public async Task RemoveUserAsync(int userId)
        {
            var user = await GetUserFromIdAsync(userId);

            if (user == null) return;

            _databaseContext.Users.Remove(user);

            await _databaseContext.SaveChangesAsync();
        }

        public Task<bool> UsernameExistsAsync(string username)
        {
            return _databaseContext.Users.AnyAsync(i => i.Username == username);
        }
    }
}
