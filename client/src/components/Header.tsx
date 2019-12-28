import React from 'react';
import { AppBar, Toolbar, Typography, Button } from '@material-ui/core';

const Header: React.FC = () => {
  return (
    <AppBar
      position="sticky"
      style={{
        backgroundColor: 'black',
      }}
    >
      <Toolbar>
        <Typography variant="h6">Winterfreizeit 2020</Typography>
      </Toolbar>
    </AppBar>
  );
};

export default Header;
