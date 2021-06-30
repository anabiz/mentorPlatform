using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using MentorsApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure
{
    public class ExpertiseRepository : IExpertiseRepository
    {
        private readonly StoreContext _context;

        public ExpertiseRepository(StoreContext context)
        {
            _context = context;

        }

        public async Task<IReadOnlyList<Expertise>> GetExpertiseAsync()
        {
            return await _context.Expertises.ToListAsync();
        }

        public async Task<Expertise> GetExpertiseByIdAsync(int id)
        {
            return await _context.Expertises.FindAsync(id);
        }

    }
}
