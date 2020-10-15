using System;
using System.Collections.Generic;
using Gregslist.Interfaces;
using Gregslist.Models;

namespace Gregslist.Services
{
  class CarsService
  {
    public List<IPurchaseable> Purchaseables { get; set;}

    internal string GetVehicles(bool avaliable)
    {
      var vehicles = Purchaseables.FindAll(v => v.IsAvaliable == avaliable);
      if(vehicles.Count == 0){
        return "Nothing Avaliable";
      }
      string carList = "";
      string truckList = "";
      for (int i = 0; i < vehicles.Count; i++)
      {
       var vehicle = vehicles[i];
       if(vehicle is Car){
         var car = (Car)vehicle;
         carList += $"{i + 1}. Make:{car.Make} Model:{car.Model} Year:{car.Year} Transmission:{car.Transmission} Fuel:{car.Fuel} Location:{car.Location} Price:{car.Price}\n";
       } else if(vehicle is Truck){
         var truck = (Truck)vehicle;
         truckList += $"{i + 1}. Make:{truck.Make} Model:{truck.Model} Year:{truck.Year} DriveTrain:{truck.FourWheelDrive} Location:{truck.Location} Price:{truck.Price}\n";
       }   
      }
      return "Cars\n" + carList + "Trucks\n" + truckList;
    }
    public CarsService()
    {
      Purchaseables = new List<IPurchaseable>(){
        new Car("Nissan","Skyline R34", 2001, 4, "E85", "Six-Speed", "Idaho", 75000.00),
        new Car("Nissan","240sx", 1993, 2, "Gasoline", "Five-Speed", "Oregon", 5000.00),
        new Car("Nissan","300zx", 1994, 2, "Gasonline", "Six-Speed", "Washington", 15000.00),
        new Car("Nissan","GTR Black Edition", 2018, 2, "E85", "Six-Speed", "New York", 125000.00),
        new Car("Honda","Civic", 1997, 2, "Gasoline", "Automatic", "Boise", 500.00),
        new Car("Toyota","Supra", 1998, 2, "E85", "Six-Speed", "Florida", 85000.00),
        new Truck("Toyota","Tacoma",2008,6,"Four Wheel Drive", false, 15000.00,"Idaho"),
        new Truck("Toyota","Tundra",2010,7,"Four Wheel Drive", false, 17000.00,"California"),
        new Truck("Dodge","Ram 2500",1997,7,"Two Wheel Drive", true, 7000.00,"Idaho"),
        new Truck("Chevorlet","HD2500",2010,6,"Four Wheel Drive", true, 20000.00,"Utah")
      };
    }
    
  }
}