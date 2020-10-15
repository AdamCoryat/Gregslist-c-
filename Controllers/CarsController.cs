using System;
using System.Threading;
using Gregslist.Models;
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
      Console.WriteLine("Please Choose one of the following (C)ars, (T)rucks, (A)ll, (P)ost vehicle, or (B)ack");
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
          case "post":
          case "p":
            CreateListing();
            break;
          default:
            Console.WriteLine("Please Choose a Valid Selection");
            Thread.Sleep(2000);
            break;
      }
    }

    private void CreateListing()
    {
      System.Console.WriteLine("Would you like to Create a (C)ar or (T)ruck or go B(a)ck?");
      var input = Console.ReadLine().ToLower();
      switch (input)
      {
          case "car":
          case "c":
            CreateCar();
            break;
          case "t":
          case "truck":
            CreateTruck();
            break;
          default:
            Console.WriteLine("Invalid Selection");
            Thread.Sleep(2000);
            CreateListing();
            break;
      }
    }

    private void CreateTruck()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine("Please enter the information as promted");
      Thread.Sleep(1000);
      Console.Write("Make: ");
      string make = Console.ReadLine();
      Console.Write("Model: ");
      string model = Console.ReadLine();
      Console.Write("Year: ");
      var yearStr = Console.ReadLine();
      int.TryParse(yearStr, out int year);
      Console.Write("BedLength: ");
      var bedLStr = Console.ReadLine();
      int.TryParse(bedLStr, out int bedLength);
      Console.Write("Fuel Type:");
      string fuel = Console.ReadLine();
      Console.Write("Drive Train:");
      string driveTrain = Console.ReadLine();
      Console.Write("Location: ");
      string location = Console.ReadLine();
      Console.Write("Price: ");
      var priceStr = Console.ReadLine();
      double.TryParse(priceStr, out double price);
      Truck newTruck = new Truck(make,model,year,bedLength,fuel,driveTrain,price,location);
      _Service.CreateTruck(newTruck);
      Console.Clear();
      Utils.PrintTruckDetails();
      Console.WriteLine("Thanks for using Gregs List to post your Truck!");
      Thread.Sleep(3000);
      GetTrucks();
    }

    private void CreateCar()
    {
      throw new NotImplementedException();
    }

    private void GetCars()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "cars"));
      Console.WriteLine("Select the # of the vehicle you want more info on or go b(a)ck.");
      string selection = Console.ReadLine();
      switch (selection)
      {
        case "back":
        case "a":
          VehiclesMenu();
          break;  
        default:
          if (int.TryParse(selection, out int index) && index > 0)
          {
            Console.Clear();
            Utils.PrintAllCarsDetails();
            Console.WriteLine(_Service.GetDetails(index - 1));
            Console.WriteLine("\nWould you like to (B)uy or go B(a)ck");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
              case "buy":
              case "b":
                Console.Clear();
                Utils.PrintAllCarsDetails();
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
      break;
      }
      
    }

    private void GetTrucks()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "trucks"));
      Console.WriteLine("Select the # of the vehicle you want more info on or go b(a)ck.");
      string selection = Console.ReadLine();
      switch (selection)
      {
        case "back":
        case "a":
          VehiclesMenu();
          break;  
        default:
          if (int.TryParse(selection, out int index) && index > 0)
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
      break;
      }
    }

    private void GetAll()
    {
      Console.Clear();
      Utils.PrintCarLogo();
      Console.WriteLine(_Service.Get(true, "all"));
      Console.WriteLine("Select the # of the vehicle you want more info on or go b(a)ck.");
      string selection = Console.ReadLine();
      switch (selection)
      {
        case "back":
        case "a":
          VehiclesMenu();
          break;  
        default:
          if (int.TryParse(selection, out int index) && index > 0)
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
                Utils.PrintAllCarsDetails();
                Console.WriteLine(_Service.Buy(index - 1));
                Thread.Sleep(4000);
                Console.Beep();
                break;
              case "back":
              case "a":
                GetAll();
                break;  
              default:
                Console.WriteLine("Invalid Selection try Again");
                break;
            }
            Console.Clear();
          }
      break;
      }
    }
  }
}