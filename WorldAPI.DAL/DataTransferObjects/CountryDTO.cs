using System;
using System.Collections.Generic;
using System.Text;

namespace WorldAPI.DAL.DataTransferObjects
{
	public class CountryDTO
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public string Iso3 { get; set; }
		public string Iso2 { get; set; }
	}
}
