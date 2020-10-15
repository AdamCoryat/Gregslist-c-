namespace Gregslist.Models
{
  class Car : Vehicle
  {
    public int Doors { get; set; }
    public string Fuel { get; set; }
    public string Transmission { get; set; }
    public Car(string make, string model, int year, int doors, string fuel, string transmission, string location, double price) : base(make, model, year,location, price)
    {
      Make = make;
      Model = model;
      Year = year;
      Doors = doors;
      Fuel = fuel;
      Transmission = transmission;
      Location = location;
      Price = price;
    }
  }
}