using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
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
		private IMapper _mapper;
		public WorldController (IRepositoryWrapper repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult GetAllCountries()
		{
			var countries = _repository.Country.FindAll();
			return Ok(countries);
		}

		[HttpGet]
		public IActionResult GetAllStates()
		{
			var states = _repository.State.FindAll();
			return Ok(states);
		}

		[HttpGet]
		public IActionResult GetAllCities()
		{
			var cities = _repository.City.FindAll();
			return Ok(cities);
		}


	}
}
