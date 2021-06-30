using System.Collections.Generic;
using System.Threading.Tasks;
using MentorsApi.Core.Entities;
using MentorsApi.Core.Interfaces;
using MentorsApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure
{
    public class MentorRepository : IMentorRepository
    {
        private readonly StoreContext _context;

        public MentorRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Mentor> GetMentorByIdAsync(int id)
        {
            return await _context.Mentors.FindAsync(id);
        }

        public async Task<IReadOnlyList<Mentor>> GetMentorsAsync()
        {
            return await _context.Mentors.ToListAsync();
        }
    }
}