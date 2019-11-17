import { DatabaseTableModel } from './DatabaseTableModel';

export interface SpotifyTrackModel extends DatabaseTableModel {
  spotifyId: string;
  created: Date;
}
