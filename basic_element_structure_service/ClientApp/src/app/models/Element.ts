export class Element{
  Name: string;
  MaxNumberOfBound: Int16Array;
  Charge: charge
}

export enum charge {
  Zero = 0,
  Positive,
  Negative
}
