using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DTO;

namespace API.Controllers
{
    [RoutePrefix ("api/travelsToUser")]
    [EnableCors(methods: "*", origins: "*", headers: "*")]
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