using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeLib;
using HomeDB.Models;
using Microsoft.AspNetCore.Cors;

namespace HomeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet("GetAllHouses")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
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
        [EnableCors("_myAllowSpecificOrigins")]
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
        [EnableCors("_myAllowSpecificOrigins")]
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
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult DeleteHouse(int id)
        {
            try
            {
                _houseService.DeleteHouse(id);
                return AcceptedAtAction("DeleteHouse");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
