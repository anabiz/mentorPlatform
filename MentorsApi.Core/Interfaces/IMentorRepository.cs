using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;

namespace MentorsApi.Core.Interfaces
{
    public interface IMentorRepository
    {
        Task<Mentor> GetMentorByIdAsync(int id);
        Task<IReadOnlyList<Mentor>> GetMentorsAsync();
    }
}