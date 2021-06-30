using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;

namespace MentorsApi.Core.Interfaces
{
    public interface ILanguageRepository
    {
        Task<Language> GetLanguageByIdAsync(int id);
        Task<IReadOnlyList<Language>> GetLanguageAsync();
    }
}
