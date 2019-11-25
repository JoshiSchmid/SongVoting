import React, { useEffect, useRef } from 'react';

interface ComponentProps {
  songId: string;
  liked?: boolean;
}

const SpotifyTrack: React.FC<ComponentProps> = ({ songId, liked }) => {
  const mounted = useRef(false);

  useEffect(() => {
    // ugly hack to simulate componentDidUpdate
    if (!mounted.current) {
      mounted.current = true;
      return;
    }

    fetch('http://localhost:5000/api/songs/' + songId, {
      method: 'POST',
      body: JSON.stringify(liked),
      headers: [['Content-Type', 'application/json']],
    })
      .then()
      .catch(err => console.error(err));
  }, [songId, liked]);

  return (
    <iframe
      title={songId}
      src={'https://open.spotify.com/embed/track/' + songId}
      width={250}
      height={80}
      frameBorder={0}      
    ></iframe>
  );
};

export default SpotifyTrack;
