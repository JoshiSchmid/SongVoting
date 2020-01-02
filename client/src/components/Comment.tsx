import React, { useState } from 'react';
import { TextField, Button } from '@material-ui/core';

interface ComponentProps {
  comment?: string;
  voteId: number;
}

const Comment: React.FC<ComponentProps> = (props: ComponentProps) => {
  const [comment, setComment] = useState<string>(
    props.comment ? props.comment : '',
  );

  const saveComment = async () => {
    await fetch(
      `${process.env.REACT_APP_API_URL}/votes/${props.voteId}/comment`,
      {
        credentials: 'include',
        method: 'POST',
        body: JSON.stringify(comment),
        headers: { 'Content-Type': 'application/json' },
      },
    );
  };

  return (
    <div>
      <TextField
        placeholder="Kommentar..."
        inputProps={{
          style: {
            color: 'white',
          },
        }}
        value={comment}
        onChange={e => setComment(e.target.value)}
        fullWidth
        style={{
          marginBottom: 5,
        }}
      />

      <Button onClick={saveComment} variant="contained" color="primary">
        Speichern
      </Button>
    </div>
  );
};

export default Comment;
