using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SongVoting.API.Models.Database
{
    public class SpotifyTrack : DatabaseTable
    {
        public string SpotifyId { get; set; }

        public DateTime Added { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }

    public class SpotifyTrackConfiguration : IEntityTypeConfiguration<SpotifyTrack>
    {
        public void Configure(EntityTypeBuilder<SpotifyTrack> builder)
        {
            builder.HasMany(i => i.Votes).WithOne().HasForeignKey(i => i.SpotifyTrackId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}