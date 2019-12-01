using System.Collections.Generic;
using System.Threading.Tasks;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public interface ISpotifyTrackService
    {
        Task<List<SpotifyTrack>> GetTracksAsync();
    }
}