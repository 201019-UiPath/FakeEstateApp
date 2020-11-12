using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeLib;

namespace HomeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        HouseService _houseService;

        public HouseController(HouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet("GetAllHouses")]
        [Produces("application/json")]
        public IActionResult GetAllHouses()
        {
            try
            {
                return Ok(_houseService.GetAllHouses());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
