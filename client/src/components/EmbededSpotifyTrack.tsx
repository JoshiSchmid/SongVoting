import React from 'react';

interface ComponentProps {
  songId: string;
}

const EmbededSpotifyTrack: React.FC<ComponentProps> = ({ songId }) => {
  return (
    <iframe
      src={'https://open.spotify.com/embed/track/' + songId}
      width={300}
      height={80}
      frameBorder={0}
    ></iframe>
  );
};

export default EmbededSpotifyTrack;
