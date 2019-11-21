import React, { useState, ReactNode } from 'react';
import ThumbUpIcon from '@material-ui/icons/ThumbUp';
import ThumbDownIcon from '@material-ui/icons/ThumbDown';
import { Button } from '@material-ui/core';

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
      <Button
        className="icon-button"
        onClick={handleLike}
        variant="outlined"
        style={{
          marginBottom: 28,
        }}
      >
        <ThumbUpIcon className="Icon"  style={{color: liked ? "blue" : ""}}/>
      </Button>
      <Button
        className="icon-button"
        onClick={handleDislike}
        variant="outlined"
        style={{
          marginBottom: 28,
          
        }}
      >
        <ThumbDownIcon className="Icon" style={{color: liked === false ? "red" : ""}}/>
      </Button>
    </div>
  );
};

export default VotingItem;
