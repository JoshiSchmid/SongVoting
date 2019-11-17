using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public class VotingSessionItemVoteService : IVotingSessionItemVoteService
    {
        private readonly DatabaseContext _databaseContext;

        public VotingSessionItemVoteService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<VotingSessionItemVote> AddVoteAsync(int votingSessionItemId, int userId, bool liked, DateTime added)
        {
            var vote = new VotingSessionItemVote
            {
                VotingSessionItemId = votingSessionItemId,
                UserId = userId,
                Liked = liked,
                Added = added
            };

            await _databaseContext.VotingSessionItemVotes.AddAsync(vote);

            await _databaseContext.SaveChangesAsync();

            return vote;
        }

        public Task<VotingSessionItemVote> GetVoteFromIdAsync(int votingSessionItemVoteId)
        {
            return _databaseContext.VotingSessionItemVotes.FirstOrDefaultAsync(i => i.Id == votingSessionItemVoteId);
        }

        public async Task RemoveVoteAsync(int votingSessionItemVoteId)
        {
            var vote = await GetVoteFromIdAsync(votingSessionItemVoteId);

            if (vote == null) return;

            _databaseContext.VotingSessionItemVotes.Remove(vote);

            await _databaseContext.SaveChangesAsync();
        }
    }
}
