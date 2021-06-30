using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using MentorsApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure
{
    public class AreaOfMentoringRepository : IAreaOfMentoringRepository
    {
        private readonly StoreContext _context;

        public AreaOfMentoringRepository(StoreContext context)
        {
            _context = context;

        }
 
        public async Task<IReadOnlyList<AreaOfMentoring>> GetAreaOfMentoringAsync()
        {
            return await _context.AreaOfMentorings.ToListAsync();
        }

        public async Task<AreaOfMentoring> GetAreaOfMentoringByIdAsync(int id)
        {
            return await _context.AreaOfMentorings.FindAsync(id);
        }
    }
}
