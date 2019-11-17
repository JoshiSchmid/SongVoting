using Microsoft.EntityFrameworkCore;

namespace SongVoting.API.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Test User" }
            );

            modelBuilder.Entity<SpotifyTrack>().HasData(
                new SpotifyTrack { Id = 1, SpotifyId = "3BQ4q1bmonEIteIrlt1zxm" },
                new SpotifyTrack { Id = 2, SpotifyId = "4UPk6n78h6dHxEgIx0Lxh3" },
                new SpotifyTrack { Id = 3, SpotifyId = "0JO1CEUuyozopyTLPEMmhj" },
                new SpotifyTrack { Id = 4, SpotifyId = "1UCJecpXZ6mSReWOoHq8t7" },
                new SpotifyTrack { Id = 5, SpotifyId = "7HsjQDosSNy6qr1IFhUsXe" }
            );

            modelBuilder.Entity<VotingSession>().HasData(
                new VotingSession { Id = 1, OwnerId = 1, Name = "Freizeit" }
            );

            modelBuilder.Entity<VotingSessionItem>().HasData(
                new VotingSessionItem { Id = 1, VotingSessionId = 1, ItemId = 1 },
                new VotingSessionItem { Id = 2, VotingSessionId = 1, ItemId = 2 },
                new VotingSessionItem { Id = 3, VotingSessionId = 1, ItemId = 3 }
            );

            modelBuilder.Entity<VotingSessionItemVote>().HasData(
                new VotingSessionItemVote { Id = 1, UserId = 1, VotingSessionItemId = 1, Liked = false },
                new VotingSessionItemVote { Id = 2, UserId = 1, VotingSessionItemId = 3, Liked = true }
            );
        }

        public DbSet<User> Users { get; set; }

        public DbSet<VotingSession> VotingSessions { get; set; }

        public DbSet<VotingSessionItem> VotingSessionItems { get; set; }

        public DbSet<VotingSessionItemVote> VotingSessionItemVotes { get; set; }

        public DbSet<SpotifyTrack> SpotifyTracks { get; set; }
    }
}
