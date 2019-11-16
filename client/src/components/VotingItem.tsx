import React, { useState, useEffect } from 'react';
import { TestValue } from '../models/TestValue';

interface ComponentProps {
  item: TestValue;
}

const VotingItem: React.FC<ComponentProps> = ({ item, children }) => {
  const [liked, setLiked] = useState(item.liked);

  useEffect(() => {}, [liked]);

  const handleLike = () => {
    setLiked(oldLiked => (oldLiked !== true ? true : undefined));
  };

  const handleDislike = () => {
    setLiked(oldLiked => (oldLiked !== false ? false : undefined));
  };

  return (
    <div>
      {children}
      <button onClick={handleLike}>Like</button>
      <button onClick={handleDislike}>Dislike</button>
      {liked === true ? 'Liked' : liked === false ? 'Disliked' : ''}
    </div>
  );
};

export default VotingItem;
