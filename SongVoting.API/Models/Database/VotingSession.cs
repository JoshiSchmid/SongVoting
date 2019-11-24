using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SongVoting.API.Models.Database
{
    public class VotingSession : DatabaseTable
    {
        public string Name { get; set; }

        public DateTime Created { get; set; }

        public ICollection<VotingSessionItem> Items { get; set; }
    }

    public class VotingSessionConfiguration : IEntityTypeConfiguration<VotingSession>
    {
        public void Configure(EntityTypeBuilder<VotingSession> builder)
        {
            builder.HasMany(i => i.Items).WithOne().HasForeignKey(i => i.VotingSessionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}