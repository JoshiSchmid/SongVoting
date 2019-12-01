using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public class SpotifyTrackService : ISpotifyTrackService
    {
        private readonly DatabaseContext _databaseContext;

        public SpotifyTrackService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<List<SpotifyTrack>> GetTracksAsync()
        {
            return _databaseContext.SpotifyTracks.ToListAsync();
        }
    }
}