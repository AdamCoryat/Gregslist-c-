namespace Gregslist.Models
{
  class Truck : Vehicle
  {
    public int BedLength { get; set; }
    public bool Diesel{ get; set; }
    public string FourWheelDrive { get; set; }
    public Truck(string make, string model, int year, int bedLength, string fourWheelDrive, bool diesel, double price, string location) : base(make, model, year, location, price)
    {
      Make = make;
      Model = model;
      Year = year;
      BedLength = bedLength;
      Diesel = diesel;
      FourWheelDrive = fourWheelDrive;
      Location = location;
      Price = price;
    }
  }
}