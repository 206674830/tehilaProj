using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meetup.BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Meetup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IOptionBL _optionBL;
        public OptionsController(IOptionBL optionBL)
        {
            _optionBL = optionBL;
        }

        [HttpGet("cities")]
        public IActionResult Cities()
        {
            return Ok(_optionBL.GetCities());
        }
    }
}
