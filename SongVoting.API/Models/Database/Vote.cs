using System;

namespace SongVoting.API.Models.Database
{
    public class Vote : DatabaseTable
    {
        public int SpotifyTrackId { get; set; }

        public bool Liked { get; set; }

        public DateTime Added { get; set; }

        public Guid UserToken { get; set; }
    }
}