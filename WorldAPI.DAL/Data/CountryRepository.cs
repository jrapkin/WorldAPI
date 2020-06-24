using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		public async Task<IEnumerable<Country>> GetAllCountriesAsync()
		{
			return await FindAll()
				.OrderByDescending(c => c.Name)
				.ToListAsync();
		}
	}
}
