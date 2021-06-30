using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using MentorsApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly StoreContext _context;

        public LanguageRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Language>> GetLanguageAsync()
        {
            return await _context.Languages.ToListAsync();

        }

        public async Task<Language> GetLanguageByIdAsync(int id)
        {
            return await _context.Languages.FindAsync(id);

        }
    }
}
