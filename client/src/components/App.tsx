import React from 'react';
import VotingSession from './VotingSession';
import Header from './Header';

const App: React.FC = () => {
  return (
    <div style={{
      backgroundColor: 'black'
    }}>
      <Header/>
      <VotingSession />
    </div>
  );
};

export default App;
