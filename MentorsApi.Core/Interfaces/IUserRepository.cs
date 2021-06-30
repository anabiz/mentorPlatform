using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;

namespace MentorsApi.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IReadOnlyList<User>> GetUsersAsync();
    }
}