using System.Collections.Generic;

namespace WorldAPI.Entities.Models
{
	public partial class State
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public int? CountryId { get; set; }
		public string CountryCode { get; set; }
		public string StateCode { get; set; }
	}
	//Additional Properties
	public partial class State
	{
		public Country Country { get; set; }
		public ICollection<City> Cities { get; set; }
	}
	//Get Methods for AutoMapper
	public partial class State
	{
		public string GetStateName()
		{
			return Name;
		}
	}
}
