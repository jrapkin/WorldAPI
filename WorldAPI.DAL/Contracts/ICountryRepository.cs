using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldAPI.DAL.Models;

namespace WorldAPI.DAL.Contracts
{
	public interface ICountryRepository : IRepositoryBase<Country>
	{
		Task<IEnumerable<Country>> GetAllCountriesAsync();


	}
}
