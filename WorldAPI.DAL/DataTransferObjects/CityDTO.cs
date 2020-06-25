using System;
using System.Collections.Generic;
using System.Text;

namespace WorldAPI.DAL.DataTransferObjects
{
	public class CityDTO
	{
        public string Name { get; set; }
        public int? StateId { get; set; }
        public string StateCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
