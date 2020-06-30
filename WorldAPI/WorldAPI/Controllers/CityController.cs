using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorldAPI.DAL.Contracts;
using WorldAPI.DTO.DataTransferObjects;
using WorldAPI.Entities.Models;

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
			if (cities == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<IEnumerable<City>, IEnumerable<CityStateCountryDTO>>(cities));
		}
	}
}

