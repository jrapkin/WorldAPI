using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WorldAPI.DAL.DataTransferObjects;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Profiles
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
