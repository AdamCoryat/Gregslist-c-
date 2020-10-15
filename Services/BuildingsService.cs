using System;
using System.Collections.Generic;
using Gregslist.Interfaces;
using Gregslist.Models;

namespace Gregslist.Services
{
  class BuildingsService
  {
    
    public List<IPurchaseable> purchaseables {get; set;}
    internal string Get(bool avaliable, string selection)
    {
      return "";
    }

    public BuildingsService()
    {
      purchaseables = new List<IPurchaseable>(){
        // new Residential("4400 W. Main St.", )

      };

    }
    
  }
}