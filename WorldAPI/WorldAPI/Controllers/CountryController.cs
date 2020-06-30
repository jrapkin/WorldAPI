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
	public class CountryController : ControllerBase
	{
		private IRepositoryWrapper _repository;
		private IMapper _mapper;
		public CountryController(IRepositoryWrapper repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		[HttpGet]
		[Route("all-countries")]
		public async Task<IActionResult> AllCountries()
		{
			IEnumerable<Country> countries = await _repository.Country.GetAllCountriesAsync();
			if (countries == null)
			{
				return NotFound();
			}
			return Ok(_mapper.Map<IEnumerable<Country>, IEnumerable<CountryDTO>>(countries));
		}
	}
}
