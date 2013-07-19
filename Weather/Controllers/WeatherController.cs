using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForecastIO;

namespace Weather.Controllers
{
    public class WeatherController : Controller
    {
        //
        // GET: /Weather/

        public ViewResult Pebble()
        {
			// /Weather/Pebble?lat=42.25889f&lon=-85.67750f
			string lat = Request.QueryString["lat"].ToString();
			string lon = Request.QueryString["lon"].ToString();

	        var client = new Models.Client();
			client.latitude = (float)Convert.ToDouble(lat); //42.25889f;
			client.longitude = (float)Convert.ToDouble(lon); //-85.67750f;
			client.unit = Unit.us; // need to figure out how to parse from query string

	        var pebble = new Models.Pebble(client);

			return View(pebble);
        }
    }
}
