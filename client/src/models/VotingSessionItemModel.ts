import { DatabaseTableModel } from './DatabaseTableModel';
import { SpotifyTrackModel } from './SpotifyTrackModel';

export interface VotingSessionItemModel extends DatabaseTableModel {
  votingSessionId: number;
  itemId: number;
  added: Date;
  item: SpotifyTrackModel;
}
