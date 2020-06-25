﻿using System;
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
		[Route("AllCountries")]
		public async Task<IActionResult> AllCountries()
		{
			var countries = await _repository.Country.GetAllCountriesAsync();
			var listOfCountryDTOs = _mapper.Map<IEnumerable<Country>, IEnumerable<CountryDTO>>(countries);


			return Ok(listOfCountryDTOs);
		}
	}
}
