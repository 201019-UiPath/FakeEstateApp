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
    public class HouseFeatureController : ControllerBase
    {
        HouseFeatureService _HouseFeatureService;

        public HouseFeatureController(HouseFeatureService HouseFeatureService)
        {
            _HouseFeatureService = HouseFeatureService;
        }

        [HttpGet("GetAllHouseFeatures")]
        [Produces("application/json")]
        public IActionResult GetAllHouseFeatures()
        {
            try
            {
                return Ok(_HouseFeatureService.GetAllHouseFeatures());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
