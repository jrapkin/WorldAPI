using System;
using System.Collections.Generic;
using System.Text;
using WorldAPI.DAL.Contracts;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Data
{
	public class CountryRepository :RepositoryBase<Country>, ICountryRepository
	{
		public CountryRepository(WorldDbContext worldDbContext)
			:base(worldDbContext)
		{
		}
	}
}
