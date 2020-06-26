using System;
using System.Collections.Generic;
using System.Text;

namespace WorldAPI.DAL.DataTransferObjects
{
	public class CityStateCountryDTO
	{
		//city
		public string CityName { get; set; }
		public double? Latitude { get; set; }
		public double? Longitude { get; set; }
		//state
		public string StateName { get; set; }	
		public string StateCode { get; set; }
		public string CountryCode { get; set; }
		//country
		public string CountryName { get; set; }
	}
}
