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
	public class StateController : ControllerBase
	{
		private IRepositoryWrapper _repository;
		private IMapper _mapper;
		public StateController(IRepositoryWrapper repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		[HttpGet]
		[Route("all-states")]
		public async Task<IActionResult> GetAllStates()
		{
			IEnumerable<State> states = await _repository.State.GetAllStatesAsync();
			if (states == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<IEnumerable<State>, IEnumerable<StateDTO>>(states));
		}

		[HttpGet]
		[Route("states-in-country")]
		public async Task<IActionResult> GetStatesByCountryId(int? id)
		{
			IEnumerable<State> states = await _repository.State.GetStatesInCountryAsync(id);
			if (states == null)
			{
				return NotFound();
			}
			return Ok(_mapper.Map<IEnumerable<State>, IEnumerable<StateDTO>>(states));
		}

	}
}
