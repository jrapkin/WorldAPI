using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Contracts
{
	public interface ICityRepository : IRepositoryBase<City>
	{
		Task<IEnumerable<City>> GetCitiesByState(int? stateId);
	}
	
}
