using System;
using System.Threading;
using Gregslist.Services;

namespace Gregslist.Controllers
{
  class CarsController
  {
    private CarsService _Service {get; set;} = new CarsService();
    public bool _Running { get; set; } = true;
   
    public void VehiclesMenu()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine("\n\nWelcome to the Vehicle Section of Gregs list!\n\n");
      Console.WriteLine("Please Choose one of the following (C)ars, (T)rucks, (A)ll, (B)ack");
      var input = Console.ReadLine().ToLower();
      switch (input)
      {
          case "cars":
          case "c":
            GetCars();
            break;
          case "trucks":
          case "t":
            GetTrucks();
            break;
          case "all":
          case "a":
            GetAll();
            break;
          case "back":
          case "b":
            new Menu().GetUserInput();
            break;
          default:
            Console.WriteLine("Please Choose a Valid Selection");
            break;
      }
    }

    private void GetCars()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "cars"));
      Console.WriteLine("Select the # of the vehicle you want more info on.");
      string intStr = Console.ReadLine();
      if (int.TryParse(intStr, out int index) && index > 0)
      {
        Console.WriteLine(_Service.GetDetails(index - 1));
        Thread.Sleep(2000);
        Console.Clear();
      }
    }

    private void GetTrucks()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "trucks"));
      Console.ReadLine();
    }

    private void GetAll()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "all"));
      Console.ReadLine();
    }
  }
}