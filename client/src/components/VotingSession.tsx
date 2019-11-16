import React, { useState, useEffect } from 'react';
import VotingItem from './VotingItem';
import SpotifyTrack from './SpotifyTrack';
import { Song } from '../models/Song';

const VotingSession: React.FC = () => {
  const [items, setItems] = useState<Song[]>([]);

  useEffect(() => {
    fetch('http://localhost:5000/api/songs')
      .then(resp => resp.json())
      .then(resp => {
        setItems(resp);
      })
      .catch(err => console.error(err));
  }, []);

  return (
    <div>
      {items.map((item, index) => (
        <VotingItem key={index}>
          {liked => <SpotifyTrack songId={item.songId} liked={liked} />}
        </VotingItem>
      ))}
    </div>
  );
};

export default VotingSession;
