import { DatabaseTableModel } from './DatabaseTableModel';
import { VoteModel } from './VoteModel';

export interface SpotifyTrackModel extends DatabaseTableModel {
  spotifyId: string;
  created: Date;
  votes: VoteModel[];
}
