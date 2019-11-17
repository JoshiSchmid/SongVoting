using System;

namespace SongVoting.API.Models.Database
{
    public class SpotifyTrack : DatabaseTable
    {
        public string SpotifyId { get; set; }

        public DateTime Created { get; set; }
    }
}