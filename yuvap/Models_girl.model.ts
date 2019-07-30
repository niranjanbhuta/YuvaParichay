import {} from 'class-validator';

export class Girl {
  public id: number;

  public mobileNum: string;

  
  public pref1: number;

  
  public pref2: number;

  
  public pref3: number;

  
  public pref4: number;

  
  public pref5: number;

  
  public pref6: number;

  
  public pref7: number;

  
  public pref8: number;

  public pref9: number;

  public pref10: number;

  constructor(
    id?: number,
    mobileNum?: string,
    pref1?: number,
    pref2?: number,
    pref3?: number,
    pref4?: number,
    pref5?: number,
    pref6?: number,
    pref7?: number,
    pref8?: number,
    pref9?: number,
    pref10?: number,
    ) {
    this.id = id || 0;
    this.mobileNum = mobileNum || '';
    this.pref1 = pref1 || null;
    this.pref2 = pref2 || null;
    this.pref3 = pref3 || null;
    this.pref4 = pref4 || null;
    this.pref5 = pref5 || null;
    this.pref6 = pref6 || null;
    this.pref7 = pref7 || null;
    this.pref8 = pref8 || null;
    this.pref9 = pref9 || null;
    this.pref10 = pref10 || null;
  }
}
