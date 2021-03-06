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
    [RoutePrefix("api/travelsToUser")]

    public class TravelToUserController : ApiController
    {
        [Route ("getAllTravelsToUser")]
        [HttpGet]
        public List<TravelToUserDTO> GetTravelsToUser(string id)
        {
            return TravelToUserBL.GetAllTravelsToUser(id);
        }

    }
}