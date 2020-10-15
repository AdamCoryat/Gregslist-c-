using Gregslist.Interfaces;

namespace Gregslist.Models
{
class Vehicle : IPurchaseable
{
    
    public string Location { get; set; }
    public double Price { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsAvaliable { get; set; }

     public double CalcualteTax()
    {
      return Price + (Price * .07);
    }
    public Vehicle(string make, string model, int year, string location, double price)
    {
      Make = make;
      Model = model;
      Year = year;
      Location = location;
      Price = price;
      IsAvaliable = true;
    }   
  }
}