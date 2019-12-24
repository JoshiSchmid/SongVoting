import React, { useEffect, useRef } from 'react';
import {VoteModel} from '../models/VoteModel'

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
        const vote = await fetch('http://localhost:5000/api/votes', {
          method: 'POST',
          body: JSON.stringify({
            spotifyTrackId: id,
            liked: liked,
          }),
          headers: [['Content-Type', 'application/json']],
          credentials: 'include',
        });
        const data = (await vote.json()) as VoteModel;
        console.log(data);
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
