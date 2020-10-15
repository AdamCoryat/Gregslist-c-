namespace Gregslist.Interfaces
{
  interface IPurchaseable
  {
    double Price { get; }
    string Location { get; }
    bool IsAvaliable { get; set; }
    double CalcualteTax();
  }
}