using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public class VotingSessionService : IVotingSessionService
    {
        private readonly DatabaseContext _databaseContext;

        public VotingSessionService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<VotingSession> AddVotingSessionAsync(int ownerId, string name, DateTime created)
        {
            var votingSession = new VotingSession
            {
                OwnerId = ownerId,
                Name = name,
                Created = created
            };

            await _databaseContext.VotingSessions.AddAsync(votingSession);

            await _databaseContext.SaveChangesAsync();

            return votingSession;
        }

        public Task<VotingSession> GetMostRecentVotingSessionAsync()
        {
            return _databaseContext.VotingSessions.Include(i => i.Owner).Include(i => i.Items).ThenInclude(i => i.Item).LastOrDefaultAsync();
        }

        public Task<VotingSession> GetVotingSessionFromIdAsync(int votingSessionId)
        {
            return _databaseContext.VotingSessions.FirstOrDefaultAsync(i => i.Id == votingSessionId);
        }

        public Task<List<VotingSession>> GetVotingSessionsAsync()
        {
            return _databaseContext.VotingSessions.Include(i => i.Owner).ToListAsync();
        }

        public async Task RemoveVotingSessionAsync(int votingSessionId)
        {
            var votingSession = await GetVotingSessionFromIdAsync(votingSessionId);

            if (votingSession == null) return;

            _databaseContext.VotingSessions.Remove(votingSession);

            await _databaseContext.SaveChangesAsync();
        }
    }
}