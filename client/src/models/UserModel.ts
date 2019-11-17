import { DatabaseTableModel } from './DatabaseTableModel';

export interface UserModel extends DatabaseTableModel {
  username: string;
  created: Date;
}
