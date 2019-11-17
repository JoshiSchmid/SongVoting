using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SongVoting.API.Models.Database
{
    public class VotingSession : DatabaseTable
    {
        public int OwnerId { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public User Owner { get; set; }

        public ICollection<VotingSessionItem> Items { get; set; }
    }

    public class VotingSessionConfiguration : IEntityTypeConfiguration<VotingSession>
    {
        public void Configure(EntityTypeBuilder<VotingSession> builder)
        {
            builder.HasOne(i => i.Owner).WithMany().HasForeignKey(i => i.OwnerId);
            builder.HasMany(i => i.Items).WithOne().HasForeignKey(i => i.VotingSessionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}