using AutoMapper;
using WorldAPI.DTO.DataTransferObjects;
using WorldAPI.Entities.Models;

namespace WorldAPI.Profiles
{
	public class StateProfile : Profile
	{
		public StateProfile()
		{
			CreateMap<State, StateDTO>();
			CreateMap<State, CityStateCountryDTO>()
					.IncludeMembers(s => s.Country);
		}
	}
}
