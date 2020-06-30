using System.Collections.Generic;
using System.Threading.Tasks;
using WorldAPI.Entities.Models;

namespace WorldAPI.DAL.Contracts
{
	public interface ICountryRepository : IRepositoryBase<Country>
	{
		Task<IEnumerable<Country>> GetAllCountriesAsync();


	}
}
