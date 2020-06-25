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
		[Route("StatesByCountryId")]
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
