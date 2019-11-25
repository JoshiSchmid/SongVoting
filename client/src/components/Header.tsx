import React from 'react';
import { AppBar, Toolbar, Typography, Button } from '@material-ui/core';

const Header: React.FC = () => {
  return (
    <AppBar
      position="sticky"
      style={{
        backgroundColor: 'black'
      }}
    >
      <Toolbar>
        <Typography variant="h6">Winterfreizeit 2020</Typography>

        <Button
          style={{
            display: 'flex',
            marginLeft: 'auto',
            textTransform: 'none',
            color: 'white',
            borderColor: 'white'
          }}
          variant="outlined"
        >
          <Typography variant="h6">Speichern</Typography>
        </Button>
      </Toolbar> 
    </AppBar>
  );
};

export default Header;
