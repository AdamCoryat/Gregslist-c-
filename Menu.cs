using System;
using Gregslist.Controllers;

namespace Gregslist
{
  class Menu
  {
    public CarsController carsController {get; set;} =  new CarsController();
    public BuildingsController buildingsController {get; set;} = new BuildingsController();
    public bool _Running { get; set; } = true;
     public void Run()
    {
      while (_Running){
        GetUserInput();
      } 
    }

    public void GetUserInput()
    {
      Console.Clear();
      Utils.Printlogo();
      Console.WriteLine("\n\nSelect what you are looking for Today. (V)ehicles, (B)uildings, (J)obs, (Q)uit");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "vehicles":
        case "v":
          carsController.VehiclesMenu();
          break;
        case "buildlings":
        case "b":
          buildingsController.BuildingMenu();
          break;
        case "jobs":
        case "j":
          break;
          // GetJobs();
        case "quit":
        case "q":
          _Running = false;
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
      
    }
  }
}