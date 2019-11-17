import { DatabaseTableModel } from './DatabaseTableModel';
import { UserModel } from './UserModel';
import { VotingSessionItemModel } from './VotingSessionItemModel';

export interface VotingSessionModel extends DatabaseTableModel {
  ownerId: number;
  name: string;
  created: Date;
  owner: UserModel;
  items: VotingSessionItemModel[];
}
