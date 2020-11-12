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
    public class FeatureController : ControllerBase
    {
        FeatureService _FeatureService;

        public FeatureController(FeatureService FeatureService)
        {
            _FeatureService = FeatureService;
        }

        [HttpGet("GetAllFeatures")]
        [Produces("application/json")]
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
    }
}
