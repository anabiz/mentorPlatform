using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using MentorsApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreContext _context;

        public UserRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IReadOnlyList<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}