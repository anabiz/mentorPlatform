using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;

namespace MentorsApi.Core.Interfaces
{
    public interface IAreaOfMentoringRepository
    {
        Task<AreaOfMentoring> GetAreaOfMentoringByIdAsync(int id);
        Task<IReadOnlyList<AreaOfMentoring>> GetAreaOfMentoringAsync();
    }
}
