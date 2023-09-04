//===============================================================
//Copyright (c) Qahorov
//Free to use Comfort and peace
//===============================================================



using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello Flutter!");
        }



    }
}
