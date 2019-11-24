using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Services
{
    public interface IVotingSessionService
    {
        Task<List<VotingSession>> GetVotingSessionsAsync();

        Task<VotingSession> GetVotingSessionFromIdAsync(int votingSessionId);

        Task<VotingSession> GetMostRecentVotingSessionAsync();

        Task<VotingSession> AddVotingSessionAsync(string name, DateTime created);

        Task RemoveVotingSessionAsync(int votingSessionId);
    }
}
