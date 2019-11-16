import React, { useState, ReactNode } from 'react';

interface ComponentProps {
  children: (liked?: boolean) => ReactNode;
}

const VotingItem: React.FC<ComponentProps> = ({ children }) => {
  const [liked, setLiked] = useState<boolean | undefined>();

  const handleLike = () => {
    setLiked(oldLiked => (oldLiked !== true ? true : undefined));
  };

  const handleDislike = () => {
    setLiked(oldLiked => (oldLiked !== false ? false : undefined));
  };

  return (
    <div>
      {children(liked)}
      <button onClick={handleLike}>Like</button>
      <button onClick={handleDislike}>Dislike</button>
      {liked === true ? 'Liked' : liked === false ? 'Disliked' : ''}
    </div>
  );
};

export default VotingItem;
