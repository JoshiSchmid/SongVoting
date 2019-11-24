import React from 'react';
import { AppBar, Toolbar, Typography } from '@material-ui/core';

const Header: React.FC = () => {
  return (
    <AppBar position="sticky">
      <Toolbar>
        <Typography variant="h6">Winterfreizeit 2020</Typography>
      </Toolbar>
    </AppBar>
  );
};

export default Header;
