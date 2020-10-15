using System;

namespace Gregslist.Controllers
{
  class MenuController
  {
    public CarsController carsController {get; set;} =  new CarsController();
    public bool _Running { get; set; } = true;
     public void Run()
    {
      while (_Running){
        GetUserInput();
      } 
    }

    private void GetUserInput()
    {
      Console.Clear();
      Utils.Printlogo();
      Console.WriteLine("Select what you are looking for Today. (V)ehicles, (H)ouses, (J)obs");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "vehicles":
        case "v":
          carsController.VehiclesMenu();
          break;
        case "houses":
        case "h":
          // GetHouses();
          break;
        case "jobs":
        case "j":
          break;
          // GetJobs();
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
      
    }
  }
}