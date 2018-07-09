using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WorldData.Models;

namespace WorldData.Controllers
{
    public class ResultsController : Controller
    {
        [HttpPost("/results")]
        public ActionResult Results(int life, string countryOrder, string cityFilter, string cityOrder)
        {
          int userLife = life;
          string userCountryOrder = countryOrder;
          // string userCityFilter = cityFilter;
          // string userCityOrder = cityOrder;
          // System.Console.WriteLine(countryOrder);
          return View((Country.GetSome(userLife, userCountryOrder)));
          // , (City.GetSome(userCityFilter, userCityOrder))
      }
    }
}
