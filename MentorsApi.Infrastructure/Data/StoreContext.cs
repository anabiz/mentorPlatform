using System.Reflection;
using MentorsApi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<AreaOfMentoring> AreaOfMentorings { get; set; }

    }
}