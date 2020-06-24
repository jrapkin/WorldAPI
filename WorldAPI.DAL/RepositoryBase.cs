﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WorldAPI.DAL.Contracts;
using WorldAPI.DAL.Data;

namespace WorldAPI.DAL
{
	public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected WorldDbContext WorldDbContext { get; set; }
		public RepositoryBase( DbContext worldDbContext)
		{
			worldDbContext = WorldDbContext;
		}
		public IQueryable<T> FindAll()
		{
			return WorldDbContext.Set<T>().AsNoTracking();
		}
		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
		{
			return WorldDbContext.Set<T>().Where(expression).AsNoTracking();
		}
		public void Create(T entity)
		{
			WorldDbContext.Set<T>().Add(entity);
		}
		public void Update(T entity)
		{
			WorldDbContext.Set<T>().Update(entity);
		}
		public void Delete(T entity)
		{
			WorldDbContext.Set<T>().Remove(entity);
		}

	}
}