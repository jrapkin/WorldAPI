using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldAPI.DAL.Contracts;
using WorldAPI.DAL.Data;
using WorldAPI.DAL.Models;

namespace WorldAPI.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class WorldController : ControllerBase
	{
		private IRepositoryWrapper _repository;
		public WorldController (IRepositoryWrapper repository)
		{
			_repository = repository;
		}
		[HttpGet]
		public IActionResult GetAllCountries()
		{
			var countries = _repository.Country.FindAll();
			return Ok(countries);
		}		


	}
}
