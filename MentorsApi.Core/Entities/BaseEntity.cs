using System.Collections.Generic;

namespace MentorsApi.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PathUrl { get; set; }
        public string Country { get; set; }
        public bool IsEmailVerified { get; set; }
        public string password { get; set; }
        public ICollection<Expertise> Expertise { get; set; } 
        public ICollection<Language> Languages { get; set; } 
    }
}