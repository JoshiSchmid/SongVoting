using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public class VotingService : IVotingService
    {
        private readonly DatabaseContext _databaseContext;

        public VotingService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Vote> AddVoteAsync(int spotifyTrackId, Guid userToken, bool liked, string comment, DateTime added)
        {
            var vote = new Vote
            {
                SpotifyTrackId = spotifyTrackId,
                UserToken = userToken,
                Liked = liked,
                Comment = comment,
                Added = added
            };

            await _databaseContext.Votes.AddAsync(vote);

            await _databaseContext.SaveChangesAsync();

            var uwu = _databaseContext.Votes.ToList();

            return vote;
        }

        public Task<Vote> GetVoteFromIdAsync(int voteId)
        {
            return _databaseContext.Votes.FirstOrDefaultAsync(i => i.Id == voteId);
        }

        public Task<Vote> GetVoteAsync(int spotifyTrackId, Guid userToken)
        {
            return _databaseContext.Votes.FirstOrDefaultAsync(i => i.SpotifyTrackId == spotifyTrackId && i.UserToken == userToken);
        }

        public Task<List<Vote>> GetVotesFromUserAsync(Guid userToken)
        {
            return _databaseContext.Votes.Where(i => i.UserToken == userToken).ToListAsync();
        }

        public async Task UpdateVoteAsync(Vote vote, bool liked, string comment)
        {
            vote.Liked = liked;
            vote.Comment = comment;
            vote.Added = DateTime.UtcNow;

            await _databaseContext.SaveChangesAsync();
        }

        public async Task RemoveVoteAsync(int voteId)
        {
            var vote = await GetVoteFromIdAsync(voteId);

            if (vote == null) return;

            _databaseContext.Votes.Remove(vote);

            await _databaseContext.SaveChangesAsync();
        }
    }
}
