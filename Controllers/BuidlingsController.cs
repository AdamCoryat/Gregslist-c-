using System;
using System.Threading;
using Gregslist.Services;

namespace Gregslist.Controllers
{
  class BuildingsController
  {

    private BuildingsService _Service {get; set;} = new BuildingsService();
    internal void BuildingMenu()
    {
      Console.Clear();
      Utils.PrintHouseLogo();

      Console.WriteLine("\nWelcome to the Buildings Homepage!\n");
      Console.WriteLine("Please choose one of the following (R)esidental, (C)ommercial, (A)ll, (P)ost Building or (B)ack.");
      var input = Console.ReadLine().ToLower();
      switch (input)
      {
          case "residental":
          case "r":
            Console.Clear();
            GetResidential();
            break;
          case "commercial":
          case "c":
            Console.Clear();
            GetCommercial();
            break;
          case "all":
          case "a":
            Console.Clear();
            GetAll();
            break;
          case "post":
          case "p":
            Console.Clear();
            PostMenu();
            break;
          case "back":
          case "b":
            Console.Clear();
            new Menu().GetUserInput();
            break;
          default:
            Console.Clear();
            Console.WriteLine("Invalid input! Try Again!");
            Thread.Sleep(3000);
            BuildingMenu();
            break;
      }
    }

    private void GetResidential()
    {
      Utils.PrintResidentialDetails();
      Console.WriteLine(_Service.Get(true, "res"));
      Console.ReadLine();
    }

    private void GetCommercial()
    {
      Utils.PrintCommericalDetails();
      Console.WriteLine(_Service.Get(true, "com"));
      Console.ReadLine();
    }

    private void GetAll()
    {
      Utils.PrintCommericalDetails();
      Console.WriteLine(_Service.Get(true, "all"));
      Console.ReadLine();
    }

    private void PostMenu()
    {
      throw new NotImplementedException();
    }
  }
}