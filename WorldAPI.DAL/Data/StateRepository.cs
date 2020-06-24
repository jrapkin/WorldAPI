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
	public class StateRepository : RepositoryBase<State>, IStateRepository
	{
		public StateRepository(WorldDbContext worldDbContext)
			: base(worldDbContext)
		{
		}
		public async Task<IEnumerable<State>> GetAllStatesAsync()
		{
			return await FindAll()
				.OrderBy(state => state.Name)
				.ThenBy(state => state.CountryId)
				.ToListAsync();
				
		}
	}
}
