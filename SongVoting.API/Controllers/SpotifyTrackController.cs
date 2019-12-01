using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongVoting.API.Models.Database;
using SongVoting.API.Services;

namespace SongVoting.API.Controllers
{
    [Route("api/tracks")]
    public class SpotifyTrackController : AuthenticatedController
    {
        private readonly ISpotifyTrackService _spotifyTrackService;

        public SpotifyTrackController(ISpotifyTrackService spotifyTrackService)
        {
            _spotifyTrackService = spotifyTrackService;
        }

        [HttpGet]
        public Task<List<SpotifyTrack>> GetTracksAsync()
        {
            return _spotifyTrackService.GetTracksAsync();
        }
    }
}