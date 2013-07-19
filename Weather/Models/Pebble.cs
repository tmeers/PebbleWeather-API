using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForecastIO;

namespace Weather.Models
{
	public class Pebble
	{
		public Pebble(Models.Client client)
		{
			//42.25889,-85.67750
			var extendBlocks = new Extend[] 
			{
				
			};
			var excludeBlocks = new Exclude[] 
			{
				Exclude.hourly,
				Exclude.daily
			};
			var request = new ForecastIORequest("", client.latitude, client.longitude, DateTime.Now, client.unit, extendBlocks, excludeBlocks);
			var response = request.Get();

			Icons.TryGetValue(response.currently.icon, out Icon);
			Temp = response.currently.temperature;


		}

		public int Icon;
		public float Temp;
		//public 

		private Dictionary<string, int> _icons;
		public Dictionary<string, int> Icons
		{
			get
			{
				if (_icons == null)
				{
					_icons = new Dictionary<string, int>();
					_icons.Add("clear-day", 0);
					_icons.Add("clear-night", 1);
					_icons.Add("rain", 2);
					_icons.Add("snow", 3);
					_icons.Add("sleet", 4);
					_icons.Add("wind", 5);
					_icons.Add("fog", 6);
					_icons.Add("cloudy", 7);
					_icons.Add("partly-cloudy-day", 8);
					_icons.Add("partly-cloudy-night", 9);
				}

				return _icons;
			}
		}
	}
}