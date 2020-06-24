using System;
using System.Collections.Generic;
using System.Text;
using WorldAPI.DAL.Contracts;
using WorldAPI.DAL.Data;

namespace WorldAPI.DAL
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private WorldDbContext _context;
		private ICountryRepository _country;
		private IStateRepository _state;
		private ICityRepository _city;
		public RepositoryWrapper(WorldDbContext context)
		{
			_context = context;
		}
		public ICountryRepository Country
		{
			get
			{
				if (_country == null)
				{
					_country = new CountryRepository(_context);	
				}
				return _country;
			}
		}
		public IStateRepository State
		{
			get
			{
				if(_state ==null)
				{
					_state = new StateRepository(_context);
				}
				return _state;
			}
		}
		public ICityRepository City
		{
			get
			{
				if(_city ==null)
				{
					_city = new CityRepository(_context);
				}
				return _city;
			}
		}
		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
