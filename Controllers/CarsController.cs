using System;
using Gregslist.Services;

namespace Gregslist.Controllers
{
  class CarsController
  {
    private CarsService _Service {get; set;} = new CarsService();
    public bool _Running { get; set; } = true;
   
    internal void VehiclesMenu()
    {
      Console.WriteLine("Welcome to the Vehicle Section of Gregs list!\n\n Please Choose one of the following (C)ars, (T)rucks");
    }
    public void GetVehicles()
    {
      Console.Clear();
      Console.WriteLine(_Service.GetVehicles(true));
      System.Console.WriteLine("Select the (#) for the vehicle you would like to see more info about");
      var intStr = Console.ReadLine();
    }

    
  }
}