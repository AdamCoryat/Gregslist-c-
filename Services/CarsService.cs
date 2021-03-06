using System;
using System.Collections.Generic;
using Gregslist.Interfaces;
using Gregslist.Models;

namespace Gregslist.Services
{
  class CarsService
  {
    public List<IPurchaseable> Purchaseables { get; set;}

     internal string Get(bool avaliable, string selection)
    {
      var vehicles = Purchaseables.FindAll(v => v.IsAvaliable == avaliable);
      if(vehicles.Count == 0)
      {
        return "Nothing Here Sorry!";
      }
      string list = "";
      for (int i = 0; i < vehicles.Count; i++)
      {
          var vehicle = vehicles[i];
        if(selection == "cars" && vehicle is Car || selection == "all" && vehicle is Car){
          var car = (Car)vehicle;
          list += $"{i + 1}. Make: {car.Make} Model: {car.Model} Year: {car.Year}\n";
        } else if (selection == "trucks" && vehicle is Truck || selection == "all" && vehicle is Truck)
        {
          var truck = (Truck)vehicle;
          list += $"{i + 1}. Make:{truck.Make} Model:{truck.Model} Year:{truck.Year}\n";
        }
      }
      return "\n\n" + selection.ToUpper() + "\n\n" + list;
    }

    internal string GetDetails(int index)
    {
      var vehicle = Purchaseables[index];
      if (vehicle is Car)
      {
        var car = (Car)vehicle;
        return $" Make: {car.Make}\n Model: {car.Model}\n Year: {car.Year}\n Doors:{car.Doors}\n Fuel Type:{car.Fuel}\n Transmission: {car.Transmission}\n Location: {car.Location}\n Price: {car.Price}";
      } else if (vehicle is Truck)
      {
        var truck = (Truck)vehicle;
         return $" Make: {truck.Make}\n Model: {truck.Model}\n Year: {truck.Year}\n Bed Length:{truck.BedLength}ft\n Drive Train:{truck.DriveTrain}\n Fuel Type:{truck.Fuel}\n Location: {truck.Location}\n Price: {truck.Price}";
      }
      return "Invalid Entry.";
    }
    internal string Buy(int index)
    {
      Purchaseables[index].IsAvaliable = false;
      return "Congrats on your purchase!";
    }
    internal void CreateTruck(Truck newTruck)
    {
      Purchaseables.Add(newTruck);
    }
    internal void CreateCar(Car newCar)
    {
      Purchaseables.Add(newCar);
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
        new Truck("Toyota","Tacoma",2008,6,"Four Wheel Drive", "Gasoline", 15000.00,"Idaho"),
        new Truck("Toyota","Tundra",2010,7,"Four Wheel Drive", "Gasoline", 17000.00,"California"),
        new Truck("Dodge","Ram 2500",1997,7,"Two Wheel Drive", "Diesel", 7000.00,"Idaho"),
        new Truck("Chevorlet","HD2500",2010,6,"Four Wheel Drive","Diesel", 20000.00,"Utah")
      };
    }

    
  }
}