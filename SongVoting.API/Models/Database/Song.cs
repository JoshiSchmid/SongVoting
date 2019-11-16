using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SongVoting.API.Models.Database
{
    public class Song : DatabaseTable
    {
        public string SongId { get; set; }

        public ICollection<Vote> Votes { get; set; }
    }

    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasMany(i => i.Votes).WithOne().HasForeignKey(i => i.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
