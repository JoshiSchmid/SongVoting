import React, { useState } from 'react';
import { TextField, Button } from '@material-ui/core';

interface ComponentProps {
  comment?: string;
  voteId: number;
}

const CommentComponent: React.FC<ComponentProps> = (props: ComponentProps) => {
  const [comment, setComment] = useState<string>(props.comment?props.comment:"");

  const saveComment = async() => {
    const resp = await fetch(`http://localhost:5000/api/votes/${props.voteId}/comment`, {
          credentials: 'include',
          method: "POST",
          body: JSON.stringify(comment),
          headers: {"Content-Type": "application/json"}
        });
  }

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
        save
        </Button>
    </div>
  );
};

export default CommentComponent;