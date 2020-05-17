export class Element{
  Name: string;
  MaxNumberOfBounds: Int16Array;
  Charge: charge
}

export enum charge {
  Zero = 0,
  Positive,
  Negative
}
