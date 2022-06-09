using System;
using CoreCodeCamp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
	[Route("api/[controller]")]


	public class CampsController : ControllerBase
	{
		private readonly ICampRepository _repository;

		public CampsController(ICampRepository repository)
        {
			_repository = repository;
        }

		[HttpGet]
		public IActionResult GetCamps()
		{ 
			return Ok(new { Moniker = "ATL2018", Name = "Atlanta Code Camp" });
        }




	}
}

