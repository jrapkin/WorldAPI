using AutoMapper;
using WorldAPI.DTO.DataTransferObjects;
using WorldAPI.Entities.Models;

namespace WorldAPI.Profiles
{
	public class CityStateCountryProfile : Profile
	{
		public CityStateCountryProfile()
		{
			CreateMap<City, CityStateCountryDTO>()
				.IncludeMembers(c => c.State);
		}
	}
}
