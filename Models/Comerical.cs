namespace Gregslist.Models
{
  class Comercial : Building
  {
    public string Zoning { get; set; }
    public int WarehouseSqFt { get; set; }
    public int ParkingLotSqFt { get; set; }
    public int PublicBathrooms { get; set; }
      public Comercial(string address, string location, int sqFt, string zoning, int warehouseSqFt, int parkingLotSqFt, int publicBathrooms, double price) : base (address, sqFt, price, location)
    {
      Address = address;
      Location = location;
      SqFt = sqFt;
      Zoning = zoning;
      WarehouseSqFt = warehouseSqFt;
      ParkingLotSqFt = parkingLotSqFt;
      PublicBathrooms = publicBathrooms;
      Price = price;
    }
  }
}