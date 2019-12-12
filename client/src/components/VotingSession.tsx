import React, { useState, useEffect } from 'react';
import VotingItem from './VotingItem';
import SpotifyTrack from './SpotifyTrack';
import { SpotifyTrackModel } from '../models/SpotifyTrackModel';
import { VoteModel } from '../models/VoteModel';
import CommentComponent from './CommentComponent';

const VotingSession: React.FC = () => {
  const [tracks, setTracks] = useState<SpotifyTrackModel[]>();
  const [votes, setVotes] = useState<VoteModel[]>();

  useEffect(() => {
    const loadTracks = async () => {
      try {
        const resp = await fetch('http://localhost:5000/api/tracks', {
          credentials: 'include',
        });
        const data = await resp.json();

        setTracks(data);
      } catch (err) {
        console.error(err);
      }
    };

    const loadLikes = async () => {
      try {
        const resp = await fetch('http://localhost:5000/api/votes/user', {
          credentials: 'include',
        });
        const data = await resp.json();

        setVotes(data);
      } catch (err) {
        console.error(err);
      }
    };

    loadTracks();
    loadLikes();
  }, []);

  return (
    <div
      style={{
        margin: '0 auto',
        display: 'table',
        backgroundColor: 'black',
      }}
    >
      {tracks &&
        votes &&
        tracks.map((track, index) => {
          const vote = votes.find(i => i.spotifyTrackId === track.id);

          return (
            <>
              <VotingItem
                key={index}
                initialLiked={vote ? vote.liked : undefined}
              >
                {liked => (
                  <div>
                    <SpotifyTrack
                      id={track.id}
                      spotifyId={track.spotifyId}
                      liked={liked}
                    />
                    {liked !== undefined && <CommentComponent comment="" />}
                  </div>
                )}
              </VotingItem>
            </>
          );
        })}
    </div>
  );
};

export default VotingSession;
