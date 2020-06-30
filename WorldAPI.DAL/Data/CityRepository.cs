using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldAPI.DAL.Contracts;
using WorldAPI.Entities.Data;
using WorldAPI.Entities.Models;


namespace WorldAPI.DAL.Data
{
	public class CityRepository : RepositoryBase<City>, ICityRepository
	{
		public CityRepository(WorldDbContext worldDbContext)
			: base(worldDbContext)
		{
		}
		public async Task<IEnumerable<City>> GetCitiesByState(int? stateId)
		{
			return await FindByCondition(city => city.StateId == stateId).Include(city => city.State).ThenInclude(state => state.Country)
				.OrderBy(city => city.StateCode)
				.ThenBy(city => city.Name)
				.ToListAsync();
		}
	}
}
