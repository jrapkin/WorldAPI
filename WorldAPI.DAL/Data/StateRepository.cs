using System;
using System.Collections.Generic;
using System.Text;
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
	}
}
