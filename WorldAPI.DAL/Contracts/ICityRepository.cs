using System.Collections.Generic;
using System.Threading.Tasks;
using WorldAPI.Entities.Models;

namespace WorldAPI.DAL.Contracts
{
	public interface ICityRepository : IRepositoryBase<City>
	{
		Task<IEnumerable<City>> GetCitiesByState(int? stateId);
	}

}
