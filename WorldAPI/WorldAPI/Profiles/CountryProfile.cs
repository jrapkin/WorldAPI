using AutoMapper;
using WorldAPI.DTO.DataTransferObjects;
using WorldAPI.Entities.Models;

namespace WorldAPI.Profiles
{
	public class CountryProfile : Profile
	{
		public CountryProfile()
		{
			CreateMap<Country, CountryDTO>();
			CreateMap<Country, CityStateCountryDTO>();
		}
	}
}
