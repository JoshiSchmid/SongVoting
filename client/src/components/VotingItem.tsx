import React, { useState, ReactNode } from 'react';
import ThumbUpIcon from '@material-ui/icons/ThumbUp';
import ThumbDownIcon from '@material-ui/icons/ThumbDown';
import { Button } from '@material-ui/core';

interface ComponentProps {
  initialLiked?: boolean;
  children: (liked?: boolean) => ReactNode;
}

const VotingItem: React.FC<ComponentProps> = ({ children, initialLiked }) => {
  const [liked, setLiked] = useState<boolean | undefined>(initialLiked);

  const handleLike = () => {
    setLiked(oldLiked => (oldLiked !== true ? true : undefined));
  };

  const handleDislike = () => {
    setLiked(oldLiked => (oldLiked !== false ? false : undefined));
  };

  return (
    <div
      style={{
        display: 'flex',
        marginBottom: 2,
      }}
    >
      {children(liked)}
      <span>
        <Button
          className="icon-button"
          onClick={handleLike}
          variant="outlined"
          style={{
            display: 'flex',
            borderColor: 'white',
            height: 40,
          }}
        >
          <ThumbUpIcon
            className="Icon"
            style={{ color: liked ? '#21d92a' : 'white' }}
          />
        </Button>

        <Button
          className="icon-button"
          onClick={handleDislike}
          variant="outlined"
          style={{
            display: 'flex',
            borderColor: 'white',
            height: 40,
          }}
        >
          <ThumbDownIcon
            className="Icon"
            style={{ color: liked === false ? '#db1f31' : 'white' }}
          />
        </Button>
      </span>
    </div>
  );
};

export default VotingItem;
