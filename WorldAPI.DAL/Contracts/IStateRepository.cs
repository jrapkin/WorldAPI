using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Contracts
{
	public interface IStateRepository : IRepositoryBase<State>
	{
		Task<IEnumerable<State>> GetAllStatesAsync();
	}
}
