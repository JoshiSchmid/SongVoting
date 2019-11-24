using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongVoting.API.Models.Database;
using SongVoting.API.Services;

[Route("api/votingsessions")]
public class VotingSessionController : AuthenticatedController
{
    private readonly IVotingSessionService _votingSessionService;

    public VotingSessionController(IVotingSessionService votingSessionService)
    {
        _votingSessionService = votingSessionService;
    }

    [HttpGet]
    public Task<List<VotingSession>> GetVotingSessionsAsync()
    {
        return _votingSessionService.GetVotingSessionsAsync();
    }

    [HttpGet("recent")]
    public Task<VotingSession> GetMostRecentVotingSessionAsync()
    {
        return _votingSessionService.GetMostRecentVotingSessionAsync();
    }

    [HttpGet("{votingSessionId}")]
    public Task<VotingSession> GetMostRecentVotingSessionAsync(int votingSessionId)
    {
        return _votingSessionService.GetVotingSessionFromIdAsync(votingSessionId);
    }
}