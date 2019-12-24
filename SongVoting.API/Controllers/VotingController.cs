using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongVoting.API.Models;
using SongVoting.API.Models.Database;
using SongVoting.API.Services;

[Route("api/votes")]
public class VotingSessionController : AuthenticatedController
{
    private readonly IVotingService _votingService;

    public VotingSessionController(IVotingService votingSessionService)
    {
        _votingService = votingSessionService;
    }

    [HttpGet("{voteId}")]
    public Task<Vote> GetVoteFromIdAsync(int voteId)
    {
        return _votingService.GetVoteFromIdAsync(voteId);
    }

    [HttpGet("user")]
    public Task<List<Vote>> GetVotesFromUserAsync()
    {
        if (!UserToken.HasValue) return null;

        return _votingService.GetVotesFromUserAsync(UserToken.Value);
    }

    [HttpPost]
    public async Task<Vote> AddVoteAsync([FromBody] AddVoteRequest req)
    {
        if (!ModelState.IsValid || !UserToken.HasValue) return null;

        var vote = await _votingService.GetVoteAsync(req.SpotifyTrackId, UserToken.Value);

        if (vote == null)
        {
            if (req.Liked == null) return null;
            
            return await _votingService.AddVoteAsync(req.SpotifyTrackId, UserToken.Value, req.Liked.Value, req.Comment, DateTime.UtcNow);
        }
        else
        {
            if (req.Liked == null)
                await _votingService.RemoveVoteAsync(vote.Id);
            else
            {
                await _votingService.UpdateVoteAsync(vote, req.Liked.Value, req.Comment);
                return vote;
            }
        }
        return null;
    }


    [HttpPost("{voteId}/comment")]
    public async Task AddCommentAsync(int voteId, [FromBody] string comment)
    {
        var oldVote = await _votingService.GetVoteFromIdAsync(voteId);
        await _votingService.UpdateVoteAsync(oldVote, oldVote.Liked, comment);
    }
}