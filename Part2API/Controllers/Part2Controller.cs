using BusinessLayer.Abstractions;
using Entities.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Part2API.Controllers
{
    /// <summary>
    /// Second part of the test
    /// </summary>
    [RoutePrefix("api/Part2")]
    public class Part2Controller : ApiController
    {
        private readonly IDeveloperBC _developersBC;

        public Part2Controller(IDeveloperBC developersBC)
        {
            _developersBC = developersBC;
        }

        /// <summary>
        /// 2.a The first endpoint will return the contents of the attached JSON file (developers.json).  
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDevelopers/")]
        public async Task<IEnumerable<IDeveloper>> GetDevelopers()
        {
            return await _developersBC.GetDevelopers();
        }


        /// <summary>
        /// 2.b	The second will read this end point; then return all of the Developers that have a skill with a level of 8 or more. Return only the skills that are of the same type. EG if they have a ‘C#’ skill of ‘9’, only return skills of ‘type’ ‘backend’ 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDeveloperBestSkills/")]
        public async Task<IEnumerable<IDeveloper>> GetDeveloperBestSkills()
        {
            IEnumerable<IDeveloper> developers = await GetDevelopers();

            _developersBC.GetDeveloperBestSkills(ref developers);

            return developers;
        }
    }
}
