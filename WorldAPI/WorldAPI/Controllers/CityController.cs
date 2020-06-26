using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldAPI.DAL.Contracts;
using WorldAPI.DAL.DataTransferObjects;
using WorldAPI.DAL.Models;

namespace WorldAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CityController : ControllerBase
	{
		IRepositoryWrapper _repository;
		IMapper _mapper;
		public CityController(IRepositoryWrapper repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		[HttpGet]
		[Route("all-cities-in-state")]
		public async Task<IActionResult> GetCitiesByStateId(int? stateId)
		{
			IEnumerable<City> cities = await _repository.City.GetCitiesByState(stateId);
			if(cities == null)
			{
				return NotFound();
			}
			
			return Ok(_mapper.Map<IEnumerable<City>, IEnumerable<CityStateCountryDTO>>(cities));
		}
	}
}

