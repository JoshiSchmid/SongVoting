using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SongVoting.API.Models.Database
{
    public class VotingSessionItem : DatabaseTable
    {
        public int VotingSessionId { get; set; }

        public int ItemId { get; set; }

        public DateTime Added { get; set; }

        // todo: possibly generic !?
        public SpotifyTrack Item { get; set; }

        public ICollection<VotingSessionItemVote> Votes { get; set; }
    }

    public class VotingSessionItemConfiguration : IEntityTypeConfiguration<VotingSessionItem>
    {
        public void Configure(EntityTypeBuilder<VotingSessionItem> builder)
        {
            builder.HasOne(i => i.Item).WithMany().HasForeignKey(i => i.ItemId);
            builder.HasMany(i => i.Votes).WithOne().HasForeignKey(i => i.VotingSessionItemId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}