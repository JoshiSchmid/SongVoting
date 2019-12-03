namespace SongVoting.API.Models
{
    public class AddVoteRequest
    {
        public int SpotifyTrackId { get; set; }

        public bool? Liked { get; set; }

        public string? Comment { get; set; }
    }
}