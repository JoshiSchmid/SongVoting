using System;
using System.Threading.Tasks;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public interface IVotingSessionItemVoteService
    {
        Task<VotingSessionItemVote> GetVoteFromIdAsync(int votingSessionItemVoteId);

        Task<VotingSessionItemVote> AddVoteAsync(int votingSessionItemId, Guid userToken, bool liked, DateTime added);

        Task RemoveVoteAsync(int votingSessionItemVoteId);
    }
}