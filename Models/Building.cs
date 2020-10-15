using Gregslist.Interfaces;

namespace Gregslist.Models
{
  class Building : IPurchaseable
  {
    

    public string Address { get; set; }
    public int SqFt { get; set; }
    public double Price { get; set; }
    public string Location { get; set; }
    public bool IsAvaliable { get; set; }

    public double CalculateTax()
    {
      return Price + (Price * .10);
    }

   public Building(string address, int sqFt, double price, string location)
    {
      Address = address;
      SqFt = sqFt;
      Price = price;
      Location = location;
    } 
  }
}