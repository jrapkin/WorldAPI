using System;
using System.Collections.Generic;
using System.Text;
using WorldAPI.DAL.Contracts;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Data
{
	public class CityRepository : RepositoryBase<City>, ICityRepository
	{
		public CityRepository(WorldDbContext worldDbContext)
			:base(worldDbContext)
		{
		}
	}
}
