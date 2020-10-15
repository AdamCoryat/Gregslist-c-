namespace Gregslist.Models
{
  class Truck : Vehicle
  {
    public int BedLength { get; set; }
    public string Fuel{ get; set; }
    public string DriveTrain { get; set; }
    public Truck(string make, string model, int year, int bedLength, string driveTrain, string fuel, double price, string location) : base(make, model, year, location, price)
    {
      Make = make;
      Model = model;
      Year = year;
      BedLength = bedLength;
      Fuel = fuel;
      DriveTrain = driveTrain;
      Location = location;
      Price = price;
    }
  }
}