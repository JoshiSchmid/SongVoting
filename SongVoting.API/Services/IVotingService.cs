using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public interface IVotingService
    {
        Task<Vote> GetVoteFromIdAsync(int voteId);

        Task<Vote> GetVoteAsync(int spotifyTrackId, Guid userToken);

        Task<List<Vote>> GetVotesFromUserAsync(Guid userToken);

        Task<Vote> AddVoteAsync(int spotifyTrackId, Guid userToken, bool liked, DateTime added);

        Task UpdateVoteAsync(Vote vote, bool liked);

        Task RemoveVoteAsync(int voteId);
    }
}