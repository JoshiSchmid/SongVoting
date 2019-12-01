import React, { useEffect, useRef } from 'react';

interface ComponentProps {
  id: number;
  spotifyId: string;
  liked?: boolean;
}

const SpotifyTrack: React.FC<ComponentProps> = ({ id, spotifyId, liked }) => {
  const mounted = useRef(false);

  useEffect(() => {
    // ugly hack to simulate componentDidUpdate
    if (!mounted.current) {
      mounted.current = true;
      return;
    }

    const saveVote = async () => {
      try {
        await fetch('http://localhost:5000/api/votes', {
          method: 'POST',
          body: JSON.stringify({
            spotifyTrackId: id,
            liked: liked,
          }),
          headers: [['Content-Type', 'application/json']],
          credentials: 'include',
        });
      } catch (err) {
        console.error(err);
      }
    };

    saveVote();
  }, [id, liked]);

  return (
    <iframe
      title={spotifyId}
      src={'https://open.spotify.com/embed/track/' + spotifyId}
      width={250}
      height={80}
      frameBorder={0}
    ></iframe>
  );
};

export default SpotifyTrack;
