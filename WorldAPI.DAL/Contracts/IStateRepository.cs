using System.Collections.Generic;
using System.Threading.Tasks;
using WorldAPI.Entities.Models;

namespace WorldAPI.DAL.Contracts
{
	public interface IStateRepository : IRepositoryBase<State>
	{
		Task<IEnumerable<State>> GetAllStatesAsync();
		Task<IEnumerable<State>> GetStatesInCountryAsync(int? countryId);
	}
}
