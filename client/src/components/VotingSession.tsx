import React, { useState, useEffect } from 'react';
import VotingItem from './VotingItem';
import SpotifyTrack from './SpotifyTrack';
import { VotingSessionModel } from '../models/VotingSessionModel';

const VotingSession: React.FC = () => {
  const [votingSession, setvotingSession] = useState<VotingSessionModel>();

  useEffect(() => {
    fetch('http://localhost:5000/api/votingsessions/recent')
      .then(resp => resp.json())
      .then(resp => {
        setvotingSession(resp);
      })
      .catch(err => console.error(err));
  }, []);

  return (
    <div
      style={{
        margin: '0 auto',
        display: 'table',
        backgroundColor: 'black'
      }}
    >
      {votingSession && (
        <>
          {votingSession.items.map((item, index) => (
            <VotingItem key={index}>
              {liked => (
                <SpotifyTrack songId={item.item.spotifyId} liked={liked} />
              )}
            </VotingItem>
          ))}
        </>
      )}
    </div>
  );
};

export default VotingSession;
