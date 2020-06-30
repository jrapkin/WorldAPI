namespace WorldAPI.Entities.Models
{
	public partial class City
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int? StateId { get; set; }
		public string StateCode { get; set; }
		public int? CountryId { get; set; }
		public string CountryCode { get; set; }
		public double? Latitude { get; set; }
		public double? Longitude { get; set; }
	}
	//Additional Properties
	public partial class City
	{
		public State State { get; set; }
	}
	//Get Methods for AutoMapper
	public partial class City
	{
		public string GetCityName()
		{
			return Name;
		}
	}
}
