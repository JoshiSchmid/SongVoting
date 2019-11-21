import React from 'react';
import VotingSession from './VotingSession';
import Header from './Header';

const App: React.FC = () => {
  return (
    <div>
      <Header/>
      <VotingSession />
    </div>
  );
};

export default App;
