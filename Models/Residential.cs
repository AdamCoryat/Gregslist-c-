namespace Gregslist.Models
{
  class Residential : Building
  {
   

    public int Bathrooms { get; set; }
    public int YardSqFt { get; set; }
    public int Bedrooms { get; set; }
    public double GarageSize { get; set; }
    public string BonusRooms { get; set; }

     public Residential(string address, int sqFt, double price, string location, int bathrooms, int yardSqFt, int bedrooms, double garageSize, string bonusRooms) : base (address,sqFt,price,location)
    {
      Address = address;
      Location = location;
      SqFt = sqFt;
      Bathrooms = bathrooms;
      YardSqFt = yardSqFt;
      Bedrooms = bedrooms;
      GarageSize = garageSize;
      BonusRooms = bonusRooms;
      Price = Price;
    }
  }
}