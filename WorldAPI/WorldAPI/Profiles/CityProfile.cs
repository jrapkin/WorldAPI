using AutoMapper;
using WorldAPI.DTO.DataTransferObjects;
using WorldAPI.Entities.Models;

namespace WorldAPI.Profiles
{
	public class CityProfile : Profile
	{
		public CityProfile()
		{
			CreateMap<City, CityDTO>();
		}
	}
}
