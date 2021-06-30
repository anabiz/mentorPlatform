using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;

namespace MentorsApi.Core.Interfaces
{
    public interface IExpertiseRepository
    {
        Task<Expertise> GetExpertiseByIdAsync(int id);
        Task<IReadOnlyList<Expertise>> GetExpertiseAsync();
    }
}
