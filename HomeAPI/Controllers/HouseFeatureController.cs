using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeLib;
using Microsoft.AspNetCore.Cors;
using HomeDB.Models;

namespace HomeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HouseFeatureController : Controller
    {
        IHouseFeatureService _HouseFeatureService;

        public HouseFeatureController(IHouseFeatureService houseFeatureService)
        {
            _HouseFeatureService = houseFeatureService;
        }
        [HttpPost("AddHouseFeature")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult AddHouseFeature(HouseFeature housefeature)
        {
            try
            {
                _HouseFeatureService.AddHouseFeature(housefeature);
                return CreatedAtAction("AddHouseFeature", housefeature);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
