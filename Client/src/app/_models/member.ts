import { Photo } from "./photo";

export interface Member {
  id: number;
  userName: string;
  age: number;
  knownAs: string;
  photoUrl: string;
  createdAt: string;
  lastActive: string;
  gender: string;
  introduction: string;
  interests: string;
  city: string;
  country: string;
  photos: Photo[];
}
