using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using BL;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(methods: "*", origins: "*", headers: "*")]
    [RoutePrefix("api/travels")]
    public class TravelsController : ApiController
    {
        [Route("getAllTravels")]
        [HttpGet]
        public List<TravelDTO> GetAllTravels()
        {
            return TravelsBL.GetAllTravels();
        }
    }
}