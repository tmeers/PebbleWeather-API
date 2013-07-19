using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.Models
{
	//https://developer.forecast.io/docs/v2

	//https://api.forecast.io/forecast/APIKEY/LATITUDE,LONGITUDE,TIME

	/*
	APIKEY should be your Dark Sky API key. LATITUDE and LONGITUDE should be the geographic coordinates of a location in decimal degrees. (Please note that the base domain for this API request is api.forecast.io, not api.darkskyapp.com.)

	The response will be a JSON-formatted object with the following properties defined:

	latitude: The requested latitude.
	longitude: The requested longitude.
	timezone: The IANA timezone name for the requested location (e.g. America/New_York). This is the timezone used for text forecast summaries and for determining the exact start time of daily data points. (Developers are advised to rely on local system settings rather than this value if at all possible: users may deliberately set an unusual timezone, and furthermore are likely to know what they actually want better than our timezone database does.)
	offset: The current timezone offset in hours from GMT.
	currently: A data point (see below) containing the current weather conditions at the requested location.
	minutely: A data block (see below) containing the weather conditions minute-by-minute for the next hour. (This property’s name should be read as an adjective—analogously to “hourly” or “daily” and meaning “reckoned by the minute”—rather than as an adverb meaning “meticulously.” Yes, we know that this is not proper English. No, we will not change it. Complaints to this effect will be deleted with utmost prejudice.)
	hourly: A data block (see below) containing the weather conditions hour-by-hour for the next two days.
	daily: A data block (see below) containing the weather conditions day-by-day for the next week.
	alerts: An array of alert objects (see below), which, if present, contains any severe weather alerts, issued by a governmental weather authority, pertinent to the requested location.
	flags: An object containing miscellaneous metadata concerning this request. (See flags object, below.)
	*/

	// Pebble:
		//[lat],[lon]?units=[uni]&exclude=hourly,daily,alerts

	public class Client
	{
		public float latitude;
		public float longitude;
		public ForecastIO.Unit unit;
		public string exclude;
		public string extend;
		public string time;
	}
}