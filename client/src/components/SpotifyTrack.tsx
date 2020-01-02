import React, { useEffect, useRef } from 'react';
import { VoteModel } from '../models/VoteModel';

interface ComponentProps {
  id: number;
  spotifyId: string;
  liked?: boolean;
  onVoteSaved: (vote: VoteModel) => void;
  onVoteRemoved: (spotifyTrackId: number) => void;
}

const SpotifyTrack: React.FC<ComponentProps> = ({
  id,
  spotifyId,
  liked,
  onVoteSaved,
  onVoteRemoved,
}) => {
  const mounted = useRef(false);

  useEffect(() => {
    // ugly hack to simulate componentDidUpdate
    if (!mounted.current) {
      mounted.current = true;
      return;
    }

    const saveVote = async () => {
      try {
        const vote = await fetch(`${process.env.REACT_APP_API_URL}/votes`, {
          method: 'POST',
          body: JSON.stringify({
            spotifyTrackId: id,
            liked: liked,
          }),
          headers: [['Content-Type', 'application/json']],
          credentials: 'include',
        });

        if (liked === undefined) {
          onVoteRemoved(id);
          return;
        }

        const data = (await vote.json()) as VoteModel;

        onVoteSaved(data);
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
