using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SongVoting.API.Models.Database
{
    public class User : DatabaseTable
    {
        public string Username { get; set; }

        public DateTime Created { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(i => i.Votes).WithOne().HasForeignKey(i => i.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
