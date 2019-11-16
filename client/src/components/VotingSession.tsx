import React, { useState, useEffect } from 'react';
import { TestValue } from '../models/TestValue';
import VotingItem from './VotingItem';
import EmbededSpotifyTrack from './EmbededSpotifyTrack';

const testValues: TestValue[] = [
  {
    songId: '3BQ4q1bmonEIteIrlt1zxm',
  },
  {
    songId: '4UPk6n78h6dHxEgIx0Lxh3',
  },
  {
    songId: '0JO1CEUuyozopyTLPEMmhj',
  },
  {
    songId: '1UCJecpXZ6mSReWOoHq8t7',
  },
  {
    songId: '7HsjQDosSNy6qr1IFhUsXe',
  },
];

const VotingSession: React.FC = () => {
  const [items, setItems] = useState<TestValue[]>([]);

  useEffect(() => {
    setItems(testValues);
  }, []);

  return (
    <div>
      {items.map((item, index) => (
        <VotingItem key={index} item={item}>
          <EmbededSpotifyTrack songId={item.songId} />
        </VotingItem>
      ))}
    </div>
  );
};

export default VotingSession;
