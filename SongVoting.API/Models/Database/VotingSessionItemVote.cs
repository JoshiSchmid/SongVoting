using System;

namespace SongVoting.API.Models.Database
{
    public class VotingSessionItemVote : DatabaseTable
    {
        public int VotingSessionItemId { get; set; }

        public int UserId { get; set; }

        public bool Liked { get; set; }

        public DateTime Added { get; set; }

        public User User { get; set; }
    }
}