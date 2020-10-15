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
        Console.Clear();
        Utils.PrintCarDetails();
        Console.WriteLine(_Service.GetDetails(index - 1));
        Console.WriteLine("\nWould you like to (B)uy or go B(a)ck");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
            case "buy":
            case "b":
              Console.Clear();
              Utils.PrintCarDetails();
              Console.WriteLine(_Service.Buy(index - 1));
              Thread.Sleep(4000);
              Console.Beep();
              break;
            case "back":
            case "a":
              GetCars();
              break;  
            default:
              Console.WriteLine("Invalid Selection try Again");
              break;
        }
        Console.Clear();
      }
    }

    private void GetTrucks()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "trucks"));
      Console.WriteLine("Select the # of the vehicle you want more info on.");
      string intStr = Console.ReadLine();
      if (int.TryParse(intStr, out int index) && index > 0)
      {
        Console.Clear();
        Utils.PrintTruckDetails();
        Console.WriteLine(_Service.GetDetails(index - 1));
        Console.WriteLine("\nWould you like to (B)uy or go B(a)ck");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
            case "buy":
            case "b":
              Console.Clear();
              Utils.PrintTruckDetails();
              Console.WriteLine(_Service.Buy(index - 1));
              Thread.Sleep(4000);
              Console.Beep();
              break;
            case "back":
            case "a":
              GetTrucks();
              break;  
            default:
              Console.WriteLine("Invalid Selection try Again");
              break;
        }
        Console.Clear();
      }
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