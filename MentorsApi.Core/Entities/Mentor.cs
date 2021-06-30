
using System.Collections.Generic;

namespace MentorsApi.Core.Entities
{
    public class Mentor : BaseEntity
    {
        public bool IsMentorVerified { get; set; }
        public string About { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public ICollection<AreaOfMentoring> AreaOfMentoring { get; set; } 

    }
}