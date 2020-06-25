using System;
using System.Collections.Generic;
using System.Text;

namespace WorldAPI.DAL.DataTransferObjects
{
	public class StateDTO
	{
		public string Name { get; set; }
		public int? CountryId { get; set; }
		public string CountryCode { get; set; }
		public string StateCode { get; set; }
	}
}
