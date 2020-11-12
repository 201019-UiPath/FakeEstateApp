using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeLib;
using Microsoft.AspNetCore.Cors;

namespace HomeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        IFeatureService _FeatureService;

        public FeatureController(IFeatureService FeatureService)
        {
            _FeatureService = FeatureService;
        }

        [HttpGet("GetAllFeatures")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetAllFeatures()
        {
            try
            {
                return Ok(_FeatureService.GetAllFeatures());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("AddFeature")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult AddFeature(HomeDB.Models.Feature feature)
        {
            try
            {
                _FeatureService.AddFeature(feature);
                return CreatedAtAction("AddFeature", feature);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
