using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldAPI.DAL.Contracts;
using WorldAPI.Entities.Data;
using WorldAPI.Entities.Models;

namespace WorldAPI.DAL.Data
{
	public class CountryRepository : RepositoryBase<Country>, ICountryRepository
	{
		public CountryRepository(WorldDbContext worldDbContext)
			: base(worldDbContext)
		{
		}
		public async Task<IEnumerable<Country>> GetAllCountriesAsync()
		{
			return await FindAll()
				.OrderBy(c => c.Name)
				.ToListAsync();
		}
	}
}
