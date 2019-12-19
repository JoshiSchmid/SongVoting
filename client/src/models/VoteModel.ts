import { DatabaseTableModel } from './DatabaseTableModel';

export interface VoteModel extends DatabaseTableModel {
  spotifyTrackId: number;
  liked: boolean;
  added: string;
  comment: string; 
  userToken: string;
}
