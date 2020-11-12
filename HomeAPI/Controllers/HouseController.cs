using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeLib;
using HomeDB.Models;

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

        [HttpPost("AddHouse")]
        public IActionResult AddHouse(House house)
        {
            try
            {
                _houseService.AddHouse(house);
                return CreatedAtAction("AddHouse", house);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("GetHouse")]
        [Produces("application/json")]
        public IActionResult GetHouse(int houseId)
        {
            try
            {
                return Ok(_houseService.GetHouse(houseId));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("DeleteHouse")]
        public IActionResult DeleteHouse(House house)
        {
            try
            {
                _houseService.DeleteHouse(house);
                return AcceptedAtAction("DeleteHouse");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
