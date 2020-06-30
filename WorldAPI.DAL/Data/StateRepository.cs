using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldAPI.DAL.Contracts;
using WorldAPI.Entities.Data;
using WorldAPI.Entities.Models;

namespace WorldAPI.DAL.Data
{
	public class StateRepository : RepositoryBase<State>, IStateRepository
	{
		public StateRepository(WorldDbContext worldDbContext)
			: base(worldDbContext)
		{
		}
		public async Task<IEnumerable<State>> GetAllStatesAsync()
		{
			return await FindAll()
				.OrderBy(state => state.CountryId)
				.ThenBy(state => state.Name)
				.ToListAsync();
		}
		public async Task<IEnumerable<State>> GetStatesInCountryAsync(int? countryId)
		{
			return await FindByCondition(states => states.CountryId == countryId)
				.OrderBy(state => state.Name)
				.ToListAsync();
		}

	}
}
