using Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/Part2")]
    [OverrideAuthentication]
    [AllowAnonymous]
    public class Part2Controller : ApiController
    {
        public Part2Controller()
        {

        }

        private readonly IDeveloperService _developersService;

        public Part2Controller(IDeveloperService developersService)
        {
            _developersService = developersService;
        }

        [HttpGet]
        [Route("GetDevelopers/")]
        public IEnumerable<IDeveloper> GetDevelopers()
        {
            return _developersService.GetDevelopers();
        }
    }
}
