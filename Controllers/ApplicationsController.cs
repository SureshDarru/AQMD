using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AQMDCore.DataAccess;
using AQMDCore.DataModels;
using Swashbuckle.AspNetCore.Annotations;

namespace AQMDCore.Api.Controllers
{

    //changes
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        [HttpGet]
        public AQMDApplication SelectPerAppl(string applNbr)
        {
            return new ApplicationData().SelectPerAppl(applNbr);
        }
        [HttpPost("/applications/")]
        [ProducesResponseType(typeof(string), 200)]
        [SwaggerResponse(200, "Success", typeof(string))]
        [SwaggerResponse(400, "Bad Request")]
        public string Insertperappl(AQMDApplication oAQMDApplication)
        {
            return new ApplicationData().InsertPerAppl(oAQMDApplication);
        }
        [HttpPut("/applications/{applNbr}/perAppl/")]
        [ProducesResponseType(typeof(string) , 200)]
        [SwaggerResponse(200 , "Success" , typeof(string))]
        [SwaggerResponse(200 ,"Bad Request")]
        public string UpdatePerAppl(AQMDApplication oAQMDApplication , string applNbr)
        {
            return new ApplicationData().UpdatePerAppl(oAQMDApplication , applNbr);
        }
        [HttpDelete("/applications/{applNbr}/")]
        [ProducesResponseType(typeof(string), 200)]
        [SwaggerResponse(200, "Success", typeof(string))]
        [SwaggerResponse(200, "Bad Request")]
        public string DeletePerAppl(string applNbr)
        {
            return new ApplicationData().DeletePerAppl( applNbr);
        }
    }
}
