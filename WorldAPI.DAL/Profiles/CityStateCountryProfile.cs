using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WorldAPI.DAL.DataTransferObjects;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Profiles
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
