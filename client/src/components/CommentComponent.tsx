import React from 'react';
import { TextField } from '@material-ui/core';

interface ComponentProps{
    comment?: string;
}

const CommentComponent: React.FC<ComponentProps>=()=>{

    return(
        <div>
            <TextField 
            placeholder	= "Kommentar..."
            inputProps={{
                style: {
                    color: 'white'
                }
            }} 
            fullWidth
            style={{
                marginBottom: 5
            }}/>
        </div>
    );
};

export default CommentComponent;