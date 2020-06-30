namespace WorldAPI.DTO.DataTransferObjects
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
