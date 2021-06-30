using MentorsApi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentorsApi.Infrastructure.Data.Config
{
    public class MentorsConfiguration : IEntityTypeConfiguration<Mentor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Mentor> builder)
        {
            builder.Property(p=>p.password).IsRequired();
            builder.Property(p=>p.Email).IsRequired().HasMaxLength(100);
            builder.Property(p=>p.Name).IsRequired();
        }
    }
}